using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Repository;
using POSsystem.Views;
using POSsystem.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem.Views
{
    public partial class PayForm : BaseForm
    {
        private bool isLoaded;
        public int totaltopay;
        
        public LoginDetails userdata { get; set; }
        public List<SaleItemsDetail> SaleItemList { get; set; }
        public SaleHistoryDetails saleHistory { get; set; }
        public SaleHistoryDetails salesummary { get; set; }

        private SaleHistoryRepository saleHistoryRepository = new SaleHistoryRepository();
        private SaleListRepository saleListRepository = new SaleListRepository();
        private ProductRepository productRepository = new ProductRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            tboritotal.Text = Utils.ToRupiah(totaltopay);
            tbtotaltopay.Text = Utils.ToRupiah(totaltopay);
            nbpay.Text = Utils.ToRupiah(totaltopay);
            tbbalance.Text = "0";
            TickleForeColor();
            isLoaded = true;
        }

        private void numberbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void calculateBalance()
        {
            int totaltopay = Utils.ToNumbers(tbtotaltopay.Text);
            int payamount = Utils.ToNumbers(nbpay.Text);

            if (payamount < totaltopay)
            {
                tbbalance.Text = Utils.ToRupiah(payamount - totaltopay);
                TickleForeColor();
                MessageBox.Show("Uang yang dibayar tidak mencukupi");
            }
            else
            {
                tbbalance.Text = Utils.ToRupiah(payamount - totaltopay);
                TickleForeColor();
            }
        }

        private void calculatetptaltopay()
        {
            int discount = Utils.ToNumbers(nbdiscount.Text);
            int oritotal = Utils.ToNumbers(tboritotal.Text);

            if (discount > oritotal)
            {
                nbpay.Text = tboritotal.Text;
                nbdiscount.Text = "0";
                TickleForeColor();
                MessageBox.Show("Diskon melebihi total belanja");
            }
            else
            {
                tbtotaltopay.Text = Utils.ToRupiah(oritotal - discount);
                TickleForeColor();
                nbpay.Text = Utils.ToRupiah(oritotal - discount);
            }


        }

        private void nbgotdiscount(object sender, EventArgs e)
        {
            calculatetptaltopay();

        }

        private void payamounFinaltotal_changed(object sender, EventArgs e)
        {
            if(isLoaded)
                calculateBalance();
        }



        private void Paymoderadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcardflag.Checked)
            {
                tbreferenceno.ReadOnly = false;
                tbreferenceno.Enabled = true;
                tbcardno.ReadOnly = false;
                tbcardno.Enabled = true;
                nbpay.Enabled = false;
                nbpay.ReadOnly = true;
                nbpay.Text = tbtotaltopay.Text;

                tbcardno.Focus();
            }
            else if(rbcash.Checked)
            {
                nbpay.Enabled = true;
                nbpay.ReadOnly = false;
                tbreferenceno.ReadOnly = true;
                tbreferenceno.Enabled = false;
                tbcardno.ReadOnly = true;
                tbcardno.Enabled = false;

                tbcardno.Clear();
                tbreferenceno.Clear();
                
            }
        }

        private void TickleForeColor()
        {
            tbtotaltopay.BackColor = SystemColors.Control;
            tbtotaltopay.ForeColor = Color.Firebrick;
        }


        private void tbpay_Click(object sender, EventArgs e)
        {
            int discount = Utils.ToNumbers(nbdiscount.Text);
            int oritotal = Utils.ToNumbers(tboritotal.Text);
            int payamount = Utils.ToNumbers(nbpay.Text);
            int finaltotal = Utils.ToNumbers(tbtotaltopay.Text);

            if (!rbcardflag.Checked && !rbcash.Checked)
                MessageBox.Show("Silahkan pilih tipe pembayaran");
            else if (rbcardflag.Checked)
            {
                if (tbreferenceno.Text == "" && tbcardno.Text == "")
                    MessageBox.Show("Nomer kartu dan nomer reference t idak boleh kosong");
                else if (tbcardno.Text == "")
                    MessageBox.Show("Silahkan isi nomer kartu");
                else if (tbreferenceno.Text == "")
                    MessageBox.Show("Silahkan isi nomer reference");
                else
                    savedatapayment();
            }
            else if(discount > oritotal)
                MessageBox.Show("Diskon melebihi total belanja");
            else if (payamount < finaltotal)
                MessageBox.Show("Uang yang dibayar tidak mencukupi");
            else
                savedatapayment();
        }

        private void savedatapayment()
        {
            salesummary = new SaleHistoryDetails();
            if (rbcardflag.Checked)
                salesummary.payment_mode = 2;
            else if (rbcash.Checked)
                salesummary.payment_mode = 1;
            salesummary.cardno = tbcardno.Text;
            salesummary.cardreference = tbreferenceno.Text;

            salesummary.datesale = DateTime.Now;
            salesummary.originaltotal = Utils.ToNumbers(tboritotal.Text);
            salesummary.discount = Utils.ToNumbers(nbdiscount.Text);
            salesummary.totalsale = Utils.ToNumbers(tbtotaltopay.Text);
            salesummary.username = userdata.username;
            salesummary.guid = Guid.NewGuid().ToString();
            salesummary.balanceamt = Utils.ToNumbers(tbbalance.Text);


            //-------------- checked whether the item has stock------------------

            int SaleQyt = 0;
            var product = productRepository.GetAll();
            var msgnotenoughstock = "Stok item ini tidak cukup : ";
            bool notenoughstock = false;

            //we need to sum up all sale if the same product, this variable will hold all total, sample we sell 5 DUS of indomie and 10 BKS indome
            //the total sale will be (5 x 40) + 10 = 210
            var SaleQtyInItem = new List<QtySaleItem>();

            foreach (var saledetails in SaleItemList)
            {
                var producttosale = product.FirstOrDefault(x => x.id == saledetails.itemid);
                SaleQyt = saledetails.qtysale * producttosale.qty_pcs_in_container;
                if (saledetails.unitsale == producttosale.unit_pcs)
                    SaleQyt = saledetails.qtysale;

                var qtyitemdetail = new QtySaleItem();
                qtyitemdetail.itemid = saledetails.itemid;

                if (SaleQtyInItem.Count > 0)
                {
                    int currindex = 0;

                    foreach (var item in SaleQtyInItem)
                    {


                        if (item.itemid == saledetails.itemid)
                        {
                            qtyitemdetail.saleqty = item.saleqty + SaleQyt;
                            SaleQtyInItem.RemoveAt(currindex);
                            break;

                        }
                        else
                            qtyitemdetail.saleqty = SaleQyt;

                        currindex++;

                    }
                    SaleQtyInItem.Add(qtyitemdetail);
                }
                else
                {
                    qtyitemdetail.saleqty = SaleQyt;
                    SaleQtyInItem.Add(qtyitemdetail);
                }

            }

            foreach (var item in SaleQtyInItem)
            {
                var producttosale = product.FirstOrDefault(x => x.id == item.itemid);
                if (item.saleqty > producttosale.Stock)
                {
                    msgnotenoughstock = msgnotenoughstock + producttosale.name + ", ";
                    notenoughstock = true;
                }
            }

            if (notenoughstock == true)
                MessageBox.Show(msgnotenoughstock);
            else if (saleHistoryRepository.Add(salesummary))
            {
                saleHistory = saleHistoryRepository.GetByGUID(salesummary.guid);

                if (SaleItemList != null)
                {
                    if (saleListRepository.AddMany(SaleItemList, saleHistory.id))
                    {
                        var saledetails = saleListRepository.GetAll(saleHistory.id);
                        int qtysalebalance = 0;

                        foreach (var item in saledetails)
                        {

                            var productToUpdate = product.FirstOrDefault(x => x.id == item.itemid);
                            var purchasedata = purchaseRepository.GetAll(item.itemid).OrderBy(x => x.id).ToList();
                            int sellinpcs = item.qtysale * productToUpdate.qty_pcs_in_container;

                            if (item.unitsale == productToUpdate.unit_pcs)
                                sellinpcs = item.qtysale;

                            productToUpdate.Stock -= sellinpcs;

                            if (!productRepository.updateproductstock(productToUpdate))
                                MessageBox.Show("Gagal mmengupdate stok barang");

                            qtysalebalance = sellinpcs;

                            foreach (var purchase in purchasedata)
                            {
                                //check if stock(total_in_pcs field) in purchase table of the current row less than sale qty and its not 0
                                //set that stock to 0 because all the stock has been sell. the remaining sale qty will deduct in another row of that product.
                                if (purchase.total_in_pcs < qtysalebalance && purchase.total_in_pcs != 0)
                                {
                                    qtysalebalance -= purchase.total_in_pcs;
                                    purchase.total_in_pcs = 0;
                                }
                                else if (purchase.total_in_pcs > qtysalebalance)
                                {
                                    //if the stock in purchase table greater than the sale qty then we need to deduct stock with the sale qty
                                    purchase.total_in_pcs -= qtysalebalance;
                                    qtysalebalance = 0;
                                }

                                if (!purchaseRepository.Updatestock(purchase))
                                    MessageBox.Show("Gagal Mengupdate stok");

                            }
                        }
                        MessageBox.Show("Pembayaran telah berhasil");
                        Close();
                    }
                    else
                        MessageBox.Show("Gagal Menyimpan detail penjualan");
                }
            }
            else
                MessageBox.Show("Gagal menyimpan summary penjualan");
        }
    }
}

using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Model.Database;
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
        public List<ProductUnitsDetails> prodUnitList { get; set; }

        private SaleHistoryRepository saleHistoryRepository = new SaleHistoryRepository();
        private SaleListRepository saleListRepository = new SaleListRepository();
        private ProductRepository productRepository = new ProductRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private ProductUnitsRepository produnitRepository = new ProductUnitsRepository();
        public PayForm()
        {
            InitializeComponent();
            rbcash.Checked = true;
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

            
            var product = productRepository.GetAll();
            var msgnotenoughstock = "Stok item ini tidak cukup : ";
            bool notenoughstock = false;

            //we need to sum up all sale if the same product, this variable will hold all total
            var SaleQtyInItem = new List<QtySaleItem>();


            foreach (var saledetails in SaleItemList)
            {
                int SaleQyt = 0;
                var producttosale = product.FirstOrDefault(x => x.id == saledetails.itemid);
                prodUnitList = produnitRepository.GetAll(saledetails.itemid);
                var relatedunit = new ProductUnitsDetails();

                if (prodUnitList.Count > 0)
                {
                    relatedunit = prodUnitList.FirstOrDefault(x => x.unitcode == saledetails.unitsale);
                }

                if (producttosale.UnitRelated == "N")
                { 
                    if (relatedunit.pcsflag == "Y")
                        SaleQyt = saledetails.qtysale;
                    else
                        SaleQyt = relatedunit.qty * saledetails.qtysale;
                }
                else if (producttosale.UnitRelated == "Y")
                {
                    if (relatedunit.pcsflag == "Y")
                        SaleQyt = saledetails.qtysale;
                    else
                    {
                        SaleQyt = relatedunit.qty * saledetails.qtysale;
                        foreach (var produnit in prodUnitList)
                        {
                            if (produnit.seq > relatedunit.seq && produnit.pcsflag == "N")
                            {
                                SaleQyt = SaleQyt * produnit.qty;
                            }
                        }
                    }
                }

                var qtyitemdetail = new QtySaleItem();
                qtyitemdetail.itemid = saledetails.itemid;

                if (SaleQtyInItem.Count > 0)
                {
                    int currindex = 0;

                    foreach (var item in SaleQtyInItem)
                    {
                        if (item.itemid == qtyitemdetail.itemid)
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
                        //int qtysalebalance = 0;

                        foreach ( var updatestock in SaleQtyInItem)
                        {
                            var productToUpdate = product.FirstOrDefault(x => x.id == updatestock.itemid);
                            productToUpdate.Stock -= updatestock.saleqty;
                            if (!productRepository.updateproductstock(productToUpdate))
                                MessageBox.Show("Gagal mmengupdate stok barang");
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Anda yakin keluar dari halaman pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            else if(keyData == (Keys.F5))
            {
                btpay.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btpay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("complete pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBox.Show("Nomer kartu dan nomer reference tidak boleh kosong");
                    else if (tbcardno.Text == "")
                        MessageBox.Show("Silahkan isi nomer kartu");
                    else if (tbreferenceno.Text == "")
                        MessageBox.Show("Silahkan isi nomer reference");
                    else
                        savedatapayment();
                }
                else if (discount > oritotal)
                    MessageBox.Show("Diskon melebihi total belanja");
                else if (payamount < finaltotal)
                    MessageBox.Show("Uang yang dibayar tidak mencukupi");
                else
                    savedatapayment();
            }

            
        }
    }
}

using HASKA.POS.RECEIPT;
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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem.Views
{
    public partial class POSSalesEntry : Form
    {
        public List<SellingPriceDetails> SelectedItemPriceDetails { get; set; }
        public List<ProductDetails> ProductInfo { get; set; }
        public List<UnitItem> UnitInfo { get; set; }
        public LoginDetails userdata { get; set; }

        int collsqtyindex = 2;
        int rowfocusindex = 0;

        private SaleFindItemRepository saleFindItemRepository = new SaleFindItemRepository();
        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();
        public POSSalesEntry()
        {
            InitializeComponent();
            SelectedItemPriceDetails = new List<SellingPriceDetails>();
        }
               
        private void btnewsale_Click(object sender, EventArgs e)
        {
            tbdiscount.Clear();
            tbbarcodeno.Clear();
            tbitemname.Clear();
            tboritotal.Clear();
            tbtotaltopay.Clear();
            tbpay.Clear();
            tbbalance.Clear();
            gvsales.Rows.Clear();
            tbbarcodeno.Enabled = true;
            tbitemname.Enabled = true;
            iconsearch.Enabled = true;
            btdelete.Enabled = true;
            btpay.Enabled = true;
            gvsales.ReadOnly = false;
            SelectedItemPriceDetails.Clear();
        }

        private void tbbarcodeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var barcodeno = tbbarcodeno.Text;
                
                try
                {
                    if(!string.IsNullOrEmpty(tbbarcodeno.Text))
                    {
                        var selectedproduct = new ProductDetails();
                        var salesPrice = saleFindItemRepository.GetByBarcodeNo(barcodeno);

                        if (salesPrice != null)
                        {
                            selectedproduct = productRepository.GetById(salesPrice.item_id);
                            if (selectedproduct.Stock > 0)
                            {
                                DisplayData(salesPrice);
                                gvsales.CurrentCell = gvsales.Rows[rowfocusindex].Cells[collsqtyindex];
                                gvsales.BeginEdit(true);
                            }
                            else
                                MessageBox.Show("STOK " + selectedproduct.name + " KOSONG");
                        }
                        else
                        {
                            MessageBox.Show("Barang tidak ditemukan");
                            tbbarcodeno.Clear();
                        }
                                                    

                    }

                        
                }
                catch (Exception ex)
                {
                    var errMsg = "Details : " + ex.Message + Environment.NewLine + "Stacktrace : " + ex.StackTrace;
                    MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbbarcodeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        

        private void gvsales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {
                var pcsprice = Convert.ToDouble(gvsales.Rows[e.RowIndex].Cells["pcsprice"].Value);
                var newqty = Convert.ToInt32(gvsales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                gvsales.Rows[e.RowIndex].Cells["oritotal"].Value = Utils.ToRupiah(newqty * pcsprice);
                gvsales.Rows[e.RowIndex].Cells["totalsale"].Value = Utils.ToRupiah(newqty * pcsprice);

                calculateTotal();
            }

            if (e.ColumnIndex == 6)
            {
                var discount = Convert.ToInt32(gvsales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                var oritotal = Convert.ToInt32(Utils.ToNumbers(gvsales.Rows[e.RowIndex].Cells["oritotal"].Value.ToString()));
                gvsales.Rows[e.RowIndex].Cells["totalsale"].Value = Utils.ToRupiah( oritotal - discount);
                gvsales.Rows[e.RowIndex].Cells["discount"].Value = Utils.ToRupiah(discount);
                calculateTotal();
            }

            tbbarcodeno.Focus();
        }


        private void gvsales_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Anda memasukkan jumlah yang salah");
                }

            }

            if (e.ColumnIndex == 6)
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Anda memasukkan jumlah yang salah");
                }

            }
        }

        private void calculateTotal()
        {
            tboritotal.Text = Utils.ToRupiah(gvsales.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["totalsale"].Value)));
            tbtotaltopay.Text = Utils.ToRupiah(gvsales.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["totalsale"].Value)));
        }

        private void iconsearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbitemname.Text))
            {
                var item_name = tbitemname.Text;
                var form = new SearchItemList();
                form.QueriedItemName = item_name;
                form.ShowDialog();

                if (form.SelectedItemDetails != null)
                {
                    DisplayData(form.SelectedItemDetails);
                    gvsales.CurrentCell = gvsales.Rows[rowfocusindex].Cells[collsqtyindex];
                    gvsales.BeginEdit(true);
                }

            }
        }

        public void DisplayData(SellingPriceDetails priceDetails)
        {
            if (priceDetails != null)
            {
                if(!SelectedItemPriceDetails.Any(x => x.id == priceDetails.id))
                {
                    var selecteditem = ProductInfo.FirstOrDefault(x => x.id == priceDetails.item_id);
                    var selectedunit = UnitInfo.FirstOrDefault(x => x.unitcode == priceDetails.sell_unit);

                    gvsales.Rows.Add(
                        priceDetails.id,
                        selecteditem != null ? selecteditem.name : " - ",
                        priceDetails.sell_qty,
                        selectedunit != null ? selectedunit.description : " - ",
                        Utils.ToRupiah(priceDetails.sell_price),
                        Utils.ToRupiah(priceDetails.sell_price),
                        0,
                        Utils.ToRupiah(priceDetails.sell_price),
                        priceDetails.item_id,
                        priceDetails.sell_unit
                        );

                    rowfocusindex = gvsales.Rows.Count - 1;

                }
                else
                {
                    var row = gvsales.Rows.Cast<DataGridViewRow>().Where(r => Convert.ToInt32(r.Cells["salesId"].Value) == priceDetails.id).First();

                    var cellQty = row.Cells["qtysale"];
                    var newQty = Convert.ToInt32(cellQty.Value) + 1;
                    cellQty.Value = newQty;

                    var cellOriTotal = row.Cells["oritotal"];
                    cellOriTotal.Value = Utils.ToRupiah(priceDetails.sell_price * newQty);

                    row.Cells["totalsale"].Value = Utils.ToRupiah(priceDetails.sell_price * newQty);
                    //rowfocusindex = row;
                }

                SelectedItemPriceDetails.Add(priceDetails);

                calculateTotal();
                tbbarcodeno.Clear();
            }
        }

        private void POSSalesEntry_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // fill the screen
            this.Bounds = Screen.PrimaryScreen.Bounds;

            ProductInfo = productRepository.GetAll();
            UnitInfo = unitRepository.GetAll();

            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void btpay_Click(object sender, EventArgs e)
        {
            if (gvsales.SelectedRows.Count == 0)
                MessageBox.Show("Anda belum memilih barang");
            else
            {
                var saleList = new List<SaleItemsDetail>();
                var itemlistforreceipt = new List<ItemDetails>();

                foreach (DataGridViewRow row in gvsales.Rows)
                {
                    var itemDetail = new SaleItemsDetail();
                    itemDetail.itemid = Convert.ToInt32(row.Cells["item_id"].Value);
                    itemDetail.qtysale = Convert.ToInt32(row.Cells["qtysale"].Value);
                    itemDetail.unitsale = row.Cells["unitcode"].Value.ToString();
                    itemDetail.priceperitem = Convert.ToInt32(Utils.ToNumbers(row.Cells["pcsprice"].Value.ToString()));
                    itemDetail.originaltotal = Convert.ToInt32(Utils.ToNumbers(row.Cells["oritotal"].Value.ToString()));
                    itemDetail.discount = Convert.ToInt32(Utils.ToNumbers(row.Cells["discount"].Value.ToString()));
                    itemDetail.totalprice = Convert.ToInt32(Utils.ToNumbers(row.Cells["totalsale"].Value.ToString()));

                    saleList.Add(itemDetail);

                    var receiptdetail = new ItemDetails();
                    receiptdetail.ItemName = Convert.ToString(row.Cells["Itemname"].Value);
                    receiptdetail.Quantity = Convert.ToString(row.Cells["qtysale"].Value + " " + row.Cells["unitcode"].Value);
                    receiptdetail.UnitPrice = Convert.ToString(row.Cells["pcsprice"].Value);
                    receiptdetail.SubTotal = Convert.ToString(row.Cells["oritotal"].Value);

                    int disc = Convert.ToInt32(Utils.ToNumbers(row.Cells["discount"].Value.ToString()));
                    if (disc > 0)
                        receiptdetail.Discount = Convert.ToString(row.Cells["discount"].Value);


                    itemlistforreceipt.Add(receiptdetail);
                }

                var form = new PayForm();
                form.userdata = userdata;
                form.SaleItemList = saleList;
                form.totaltopay = Utils.ToNumbers(tbtotaltopay.Text);
                form.ShowDialog();
                if(form.saleHistory != null)
                {
                    reloadafterpay(form.saleHistory);

                    //show receipt
                    var receiptData = new ReceiptData();
                    receiptData.ItemList = itemlistforreceipt;
                    receiptData.StoreName = "TOKO IN SADAR";
                    receiptData.ReceiptID = form.saleHistory.id.ToString();
                    receiptData.Datetime = form.saleHistory.datesale.ToString();

                    receiptData.TotalItem = itemlistforreceipt.Count.ToString();
                    receiptData.SubTotal = Convert.ToString(Utils.ToRupiah(form.saleHistory.originaltotal));
                    receiptData.Discount = Convert.ToString(Utils.ToRupiah(form.saleHistory.discount));
                    receiptData.GrandTotal = Convert.ToString(Utils.ToRupiah(form.saleHistory.totalsale));
                    receiptData.TotalPaid = Convert.ToString(Utils.ToRupiah(form.saleHistory.balanceamt + form.saleHistory.totalsale));
                    receiptData.Balance = Convert.ToString(Utils.ToRupiah(form.saleHistory.balanceamt));

                    if (form.saleHistory.payment_mode == 1)
                        receiptData.SalePaymentMethod = PaymentMethod.Cash;
                    else
                    {
                        receiptData.SalePaymentMethod = PaymentMethod.Card;

                        string cardno = form.saleHistory.cardno.ToString();
                        string substr = cardno.Substring(cardno.Length - 4);

                        cardno = "************" + substr;

                        receiptData.CardNo = cardno;
                        receiptData.RefNo = form.saleHistory.cardreference.ToString();
                    }

                    var receipt = new Receipt { Data = receiptData };
                    receipt.CompileReceipt();
                    receipt.Print();
                }
            }

        }


        private void tbitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                iconsearch_Click(null, null);
            }
        }

        public void reloadafterpay(SaleHistoryDetails historydetails)
        {
            tbbarcodeno.Enabled = false;
            tbitemname.Enabled = false;
            iconsearch.Enabled = false;
            btdelete.Enabled = false;
            btpay.Enabled = false;
            gvsales.ReadOnly = true;

            tbdiscount.Text = Utils.ToRupiah(historydetails.discount);
            tbpay.Text = Utils.ToRupiah(historydetails.balanceamt + historydetails.totalsale);
            tbbalance.Text = Utils.ToRupiah(historydetails.balanceamt);
            tbtotaltopay.Text = Utils.ToRupiah(historydetails.totalsale);
        }



        private void btdelete_Click(object sender, EventArgs e)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            if (gvsales.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada barang yang akan dihapus");
            else
            {
                string itemname = gvsales.Rows[gvsales.CurrentCell.RowIndex].Cells["Itemname"].Value.ToString();
                itemname = myTI.ToLower(itemname);

                if (MessageBox.Show("Anda yakin menghapus " + itemname + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selid = Convert.ToInt32(gvsales.Rows[gvsales.CurrentCell.RowIndex].Cells["salesId"].Value);
                    SelectedItemPriceDetails.RemoveAll(x => x.id == selid);
                    gvsales.Rows.RemoveAt(gvsales.CurrentCell.RowIndex);
                    calculateTotal();
                }

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                tbbarcodeno.Focus();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                tbitemname.Focus();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btnewsale.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                btdelete.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F5))
            {
                btpay.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Anda yakin keluar dari halaman penjualan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

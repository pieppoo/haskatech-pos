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
    public partial class POSSalesEntry : Form
    {
        public List<SellingPriceDetails> SelectedItemPriceDetails { get; set; }
        public List<ProductDetails> ProductInfo { get; set; }
        public List<UnitItem> UnitInfo { get; set; }
        public LoginDetails userdata { get; set; }

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
        }

        private void tbbarcodeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var barcodeno = tbbarcodeno.Text;
                
                try
                {
                    var salesPrice = saleFindItemRepository.GetByBarcodeNo(barcodeno);
                    if (salesPrice != null)
                    {
                        DisplayData(salesPrice);
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak ditemukan");
                        tbbarcodeno.Clear();
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
                var newqty = Convert.ToInt32(gvsales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                var pcsprice = Convert.ToDouble(gvsales.Rows[e.RowIndex].Cells["pcsprice"].Value);

                gvsales.Rows[e.RowIndex].Cells["oritotal"].Value = Utils.ToRupiah(newqty * pcsprice);
                gvsales.Rows[e.RowIndex].Cells["totalsale"].Value = Utils.ToRupiah(newqty * pcsprice);

                calculateTotal();
            }

            if (e.ColumnIndex == 6)
            {
                var discount = Convert.ToInt32(gvsales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                var oritotal = Convert.ToInt32(Utils.ToNumbers(gvsales.Rows[e.RowIndex].Cells["oritotal"].Value.ToString()));
                gvsales.Rows[e.RowIndex].Cells["totalsale"].Value = Utils.ToRupiah( oritotal - discount);
                calculateTotal();
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

                DisplayData(form.SelectedItemDetails);
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
                }

                SelectedItemPriceDetails.Add(priceDetails);

                calculateTotal();
                tbbarcodeno.Clear();
            }
        }

        private void POSSalesEntry_Load(object sender, EventArgs e)
        {
            ProductInfo = productRepository.GetAll();
            UnitInfo = unitRepository.GetAll();
        }


        private void btpay_Click(object sender, EventArgs e)
        {
            if (gvsales.SelectedRows.Count == 0)
                MessageBox.Show("Anda belum memilih barang");
            else
            {
                var saleList = new List<SaleItemsDetail>();

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
                }

                var form = new PayForm();
                form.userdata = userdata;
                form.SaleItemList = saleList;
                form.totaltopay = Utils.ToNumbers(tbtotaltopay.Text);
                form.ShowDialog();
                reloadafterpay(form.saleHistory);
            }

        }

        private void btprint_Click(object sender, EventArgs e)
        {
            if(tbbalance.Text != "")
            {
                MessageBox.Show("do some code to print");
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
            if (gvsales.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada barang yang akan dihapus");
            else
            {
                // var id = Convert.ToInt32(gvsales.Rows[gvsales.CurrentCell.RowIndex].Cells[0].Value);

                gvsales.Rows.RemoveAt(gvsales.CurrentCell.RowIndex);
                calculateTotal();

            }
        }
    }
}

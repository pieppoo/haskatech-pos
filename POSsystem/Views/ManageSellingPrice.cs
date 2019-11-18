using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Repository;
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
    public partial class ManageSellingPrice : BaseForm
    {
        public ManageSellingPrice()
        {
            InitializeComponent();
        }
        private ProductRepository productRepository = new ProductRepository();
        public ProductDetails ProductData { get; set; }
        public PurchaseDetails PurchaseData { get; set; }
        public List<SellingPriceDetails> SellpriceList { get; set; }
        private SellingPriceRepository sellingPriceRepository = new SellingPriceRepository();

        private UnitRepository unitRepository = new UnitRepository();
        public List<UnitItem> unitList { get; set; }

        private void LoadData()
        {
            SellpriceList = sellingPriceRepository.GetAll(ProductData.id);
            unitList = unitRepository.GetAll().ToList();

            gvsellprice.Rows.Clear();

            if (SellpriceList != null)
            {
                foreach (var item in SellpriceList)
                {
                    var unitname = unitList.FirstOrDefault(x => x.unitcode == item.sell_unit);

                    gvsellprice.Rows.Add(
                        item.item_id,
                        item.id,
                        item.Barcodeno,
                        unitname != null ? unitname.description : " - ",
                        Utils.ToRupiah(item.sell_price)
                        );
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void ManageSellingPrice_Load(object sender, EventArgs e)
        {
            lbitemname.Text = "Nama Produk : " + ProductData.name;
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            LoadData();
        }

        private void btnnewprice_Click(object sender, EventArgs e)
        {
            var form = new AddEditSellPrice();
            form.ProductData = ProductData;
            form.ShowDialog();
            LoadData();

        }

        private void bteditprice_Click(object sender, EventArgs e)
        {
            if (gvsellprice.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada harga yang akan diubah");
            else
            {
                var id = Convert.ToInt32(gvsellprice.Rows[gvsellprice.CurrentCell.RowIndex].Cells["id"].Value);
                var itemprice = SellpriceList.FirstOrDefault(x => x.id == id);
                if (itemprice != null)
                {
                    var form = new AddEditSellPrice();
                    form.Editmode = true;
                    form.SellingPriceData = itemprice;
                    form.ShowDialog();
                    LoadData();
                }
            }

        }

        private void btndeleteprice_Click(object sender, EventArgs e)
        {
            if (gvsellprice.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada harga yang akan dihapus");
            else
            {
                var id = Convert.ToInt32(gvsellprice.Rows[gvsellprice.CurrentCell.RowIndex].Cells["id"].Value);

                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus harga jual terpilih?";
                form.ShowDialog();

                if (form.YES)
                {

                    if (!sellingPriceRepository.Delete(id))
                        MessageBox.Show("Gagal menghapus harga");
                    LoadData();
                }
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btnnewprice.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                bteditprice.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btndeleteprice.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Delete))
            {
                btndeleteprice.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gvsellprice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bteditprice.PerformClick();
        }

        private void gvsellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    bteditprice.PerformClick();
            }
        }
    }
}

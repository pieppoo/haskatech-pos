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
        public List<ProductDetails> ProductList { get; set; }
        public PurchaseDetails PurchaseData { get; set; }
        public List<SellingPriceDetails> SellpriceList { get; set; }
        private SellingPriceRepository sellingPriceRepository = new SellingPriceRepository();

        private UnitRepository unitRepository = new UnitRepository();
        public List<UnitItem> unitList { get; set; }

        private void LoadData()
        {
            SellpriceList = sellingPriceRepository.GetAll(PurchaseData.id);
            unitList = unitRepository.GetAll().ToList();
            ProductList = productRepository.GetAll().ToList();

            gvsellprice.Rows.Clear();

            if (SellpriceList != null)
            {
                foreach (var item in SellpriceList)
                {
                    var itemname = ProductList.FirstOrDefault(x => x.id == item.item_id);
                    var unitname = unitList.FirstOrDefault(x => x.unitcode == item.sell_unit);

                    gvsellprice.Rows.Add(
                        item.purchaseid,
                        item.item_id,
                        item.id,
                        itemname != null ? itemname.name : " - ",
                        item.sell_price,
                        unitname != null ? unitname.description : " - ",
                        item.Barcodeno
                        );
                }
            }

        }


        private void ManageSellingPrice_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnnewprice_Click(object sender, EventArgs e)
        {
            var form = new AddEditSellPrice();
            form.PurchaseData = PurchaseData;
            form.ShowDialog();
            LoadData();

        }

        private void bteditprice_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvsellprice.Rows[gvsellprice.CurrentCell.RowIndex].Cells[2].Value);
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

        private void btndeleteprice_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvsellprice.Rows[gvsellprice.CurrentCell.RowIndex].Cells[2].Value);

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
}

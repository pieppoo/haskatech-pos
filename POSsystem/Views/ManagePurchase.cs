using POSsystem.Views.Base;
using POSsystem.Database;
using POSsystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSsystem.Common;
using POSsystem.Model.Database;

namespace POSsystem.Views
{
    public partial class ManagePurchase : BaseForm
    {
        public ManagePurchase()
        {
            InitializeComponent();
        }
        public List<UnitItem> unitList { get; set; }
        public List<PurchaseDetails> purchaseList { get; set; }
        public List<ProductDetails> ProductList { get; set; }
        public ProductDetails ProductData { get; set; }
        public bool hasUnits { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        


        private void LoadData()
        {
            lbitemname.Text = "Nama Produk : " + ProductData.name;
            unitList = unitRepository.GetAll().ToList(); 
            purchaseList = purchaseRepository.GetAll(ProductData.id);
            ProductList = productRepository.GetAll().ToList();

            if(!hasUnits)
            {
                btadditem.Enabled = false;
                btdeleteitem.Enabled = false;
                btnSellPrice.Enabled = false;
            }

            gvpurchase.Rows.Clear();

            if (purchaseList != null)
            {
                foreach (var purchase in purchaseList)
                {
                    var unitpurchase = unitList.FirstOrDefault(x => x.unitcode == purchase.purchase_unit);
                    var unitpcs = unitList.FirstOrDefault(x => x.unitcode == purchase.pcs_unit);
                    var itemname = ProductList.FirstOrDefault(x => x.id == purchase.itemid);


                    gvpurchase.Rows.Add(
                        purchase.id,
                        purchase.Created_datetime,
                        unitpurchase != null ? unitpurchase.description : " - ",
                        purchase.purchase_qty,
                        Utils.ToRupiah(purchase.purchase_price)
                        );

                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ManageWarehouse_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            LoadData();
        }

        private void btadditem_Click(object sender, EventArgs e)
        {
            var form = new AddEditPurchase();
            form.ProductData = ProductData;
            form.ShowDialog();
            LoadData();
        }

        private void btdeleteitem_Click(object sender, EventArgs e)
        {
            if (gvpurchase.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada barang yang akan dihapus");
            else
            {
                var id = Convert.ToInt32(gvpurchase.Rows[gvpurchase.CurrentCell.RowIndex].Cells["id"].Value);
                var purchaseinfo = purchaseList.FirstOrDefault(x => x.id == id);

                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus barang terpilih?";
                form.ShowDialog();


                int initial_total = purchaseinfo.purchase_qty * purchaseinfo.qty_pcs_in_container;


                if (form.YES)
                {
                    if (initial_total != purchaseinfo.total_in_pcs)
                        MessageBox.Show("Anda tidak boleh menghapus barang yang sudah terjual");
                    else
                    {
                        ProductData.Stock = ProductData.Stock - purchaseinfo.total_in_pcs;
                        if (productRepository.updateproductstock(ProductData))
                        {
                            if (!purchaseRepository.Delete(id))
                                MessageBox.Show("Gagal menghapus harga");
                        }
                        else
                            MessageBox.Show("Gagal menghapus harga karena error pada pengurangan stok");
                    }

                }
                LoadData();
            }
            
        }

        private void btnSellPrice_Click(object sender, EventArgs e)
        {
            var form = new ManageSellingPrice();
            form.ProductData = ProductData;
            Hide();
            form.ShowDialog();
            Show();
            LoadData();

        }

        private void btunitproduk_Click(object sender, EventArgs e)
        {
                var form = new ManageUnitInProduct();
                form.ProductData = ProductData;
                Hide();
                form.ShowDialog();
                Show();
                LoadData();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btunitproduk.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                btadditem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btdeleteitem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                btnSellPrice.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Delete))
            {
                btdeleteitem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}

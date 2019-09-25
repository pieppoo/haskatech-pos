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

namespace POSsystem.Views
{
    public partial class ManagePurchase : BaseForm
    {
        public ManagePurchase()
        {
            InitializeComponent();
        }
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        public List<PurchaseDetails> purchaseList { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        public List<ProductDetails> ProductList { get; set; }
        public ProductDetails ProductData { get; set; }

        private UnitRepository unitRepository = new UnitRepository();
        public List<UnitItem> unitList{ get; set; }


        private void LoadData()
        {
            unitList = unitRepository.GetAll().ToList(); 
            purchaseList = purchaseRepository.GetAll(ProductData.id);
            ProductList = productRepository.GetAll().ToList();

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
                        itemname != null ? itemname.name : " - ",
                        purchase.purchase_qty,
                        unitpurchase != null ? unitpurchase.description : " - ",
                        Utils.ToRupiah(purchase.purchase_price),
                        purchase.qty_pcs_in_container,
                        unitpcs != null ? unitpcs.description : " - ",
                        purchase.total_in_pcs,
                        purchase.Created_datetime
                        );

                }
            }

        }

        private void ManageWarehouse_Load(object sender, EventArgs e)
        {
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
                var id = Convert.ToInt32(gvpurchase.Rows[gvpurchase.CurrentCell.RowIndex].Cells[0].Value);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btadditem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                btdeleteitem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
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

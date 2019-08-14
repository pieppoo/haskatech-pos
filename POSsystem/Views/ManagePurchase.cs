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

                    //double all_total_container = 0;
                    //all_total_container = purchase.total_in_pcs / purchase.qty_pcs_in_container;
                    //int total_container_in_int = 0;
                    //total_container_in_int = (int)all_total_container;
                    //int balance_pcs_total = purchase.total_in_pcs - (total_container_in_int * (int)purchase.qty_pcs_in_container);
                    //var final_total = total_container_in_int + " " + purchase.purchase_unit + " " + balance_pcs_total + " " + purchase.pcs_unit;

                    Console.WriteLine("hai");

                    gvpurchase.Rows.Add(
                        purchase.id,
                        itemname != null ? itemname.name : " - ",
                        purchase.purchase_qty,
                        unitpurchase != null ? unitpurchase.description : " - ",
                        purchase.purchase_price,
                        purchase.qty_pcs_in_container,
                        unitpcs != null ? unitpcs.description : " - ",
                        //final_total,
                        purchase.Created_datetime
                        );

                }
            }

        }

        private void ManageWarehouse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvwarehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(gvpurchase.Rows[e.RowIndex].Cells[0].Value);
            var purchase = purchaseList.FirstOrDefault(x => x.id == id);

            if (purchase != null)
            {
                var form = new ManageSellingPrice();
                form.PurchaseData = purchase;
                form.ShowDialog();
                LoadData();
            }
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
            var id = Convert.ToInt32(gvpurchase.Rows[gvpurchase.CurrentCell.RowIndex].Cells[0].Value);

            var form = new ConfirmationDialog();
            form.Message = "Apa anda yakin menghapus harga jual terpilih?";
            form.ShowDialog();

            if (form.YES)
            {

                if (!purchaseRepository.Delete(id))
                    MessageBox.Show("Gagal menghapus harga");
                LoadData();
            }
        }

        private void btedititem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvpurchase.Rows[gvpurchase.CurrentCell.RowIndex].Cells[0].Value);
            var purchaseUpdate = purchaseList.FirstOrDefault(x => x.id == id);
            if (purchaseUpdate != null)
            {
                var form = new AddEditPurchase();
                form.Editmode = true;
                form.PurchaseData = purchaseUpdate;
                form.ShowDialog();
                LoadData();
            }

        }
    }
}

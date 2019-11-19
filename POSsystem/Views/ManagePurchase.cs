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
        public ProductDetails ProductData { get; set; }
        public List<ProductUnitsDetails> produnitList { get; set; }
        bool hasUnits { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        


        private void LoadData()
        {
            lbitemname.Text = "Nama Produk : " + ProductData.name;
            unitList = unitRepository.GetAll().ToList(); 
            purchaseList = purchaseRepository.GetAll(ProductData.id);
            produnitList = productUnitsRepository.GetAll(ProductData.id).ToList();
            hasUnits = produnitList.Count>0;

            if (hasUnits)
            {
                btadditem.Enabled = true;
                btdeleteitem.Enabled = true;
                btnSellPrice.Enabled = true;
            }
            else
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


        private void ManageWarehouse_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private int calculatestock(int purchaseid)
        {
            var selectedpurchase = purchaseList.FirstOrDefault(x => x.id == purchaseid);

            var selectedunit = produnitList.FirstOrDefault(x => x.unitcode == selectedpurchase.purchase_unit);
            var pcsunit = produnitList.FirstOrDefault(x => x.pcsflag == "Y");

            int totalitem = 0;

            if (selectedunit.pcsflag == "Y")
            {
                totalitem = selectedpurchase.purchase_qty;

            }
            else if (ProductData.UnitRelated == "Y")
            {
                totalitem = selectedunit.qty * selectedpurchase.purchase_qty;
                foreach (var item in produnitList.OrderBy(x => x.seq))
                {
                    if (item.seq > selectedunit.seq && item.qty != 0)
                        totalitem = totalitem * item.qty;
                }
            }
            else
            {
                totalitem = selectedpurchase.purchase_qty * selectedunit.qty;
            }

            return totalitem;

        }

        private void btadditem_Click(object sender, EventArgs e)
        {
            var form = new AddEditPurchase();
            form.ProductData = ProductData;
            form.hasUnitList = hasUnits;
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


                int totalitemtodelete = calculatestock(id);
                var currentstock = new ProductDetails();
                currentstock = productRepository.GetById(ProductData.id);
                if (currentstock.Stock == 0)
                {
                    totalitemtodelete = 0;
                }

                if (form.YES)
                {
                    if (totalitemtodelete > currentstock.Stock && currentstock.Stock != 0)
                        MessageBox.Show("Tidak boleh menghapus pembelian ini karna total pembelian lebih besar dari pada stok yang tersisa");
                    else
                    {
                        if (!purchaseRepository.deletewithstock(id, ProductData.id, totalitemtodelete))
                            MessageBox.Show("Gagal menghapus pembelian terpilih");
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

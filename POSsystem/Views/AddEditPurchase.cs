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
    public partial class AddEditPurchase : BaseForm
    {

        public AddEditPurchase()
        {
            InitializeComponent();
        }

        public bool Editmode { get; set; }
        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private BrandRepository brandRepository = new BrandRepository();
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();

        public ProductDetails ProductData { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<Brand> BrandList { get; set; }
        public List<ProductDetails> ProductList { get; set; }
        public List<ProductUnitsDetails> ProdUnitList { get; set; }
        public bool hasUnitList { get; set; }

        private void AddEditPurchase_Load(object sender, EventArgs e)
        {
            ProductList = productRepository.GetAll().ToList();
            BrandList = brandRepository.GetAll().ToList();
            ProdUnitList = productUnitsRepository.GetAll(ProductData.id);

            if(hasUnitList)
            {
                UnitList = unitRepository.GetAll(ProductData.id);
                cbunitpurchase.DataSource = new BindingSource(UnitList, null);
                cbunitpurchase.DisplayMember = "description";
                cbunitpurchase.ValueMember = "unitcode";
            }

            lbname.Text = ProductData.name;
            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!Editmode)
            {
                if (tbpurchaseprice.Value == 0 || numpurchaseqty.Value == 0)
                    MessageBox.Show("Harga beli atau jumlah beli tidak boleh nol (0)");
                else
                {
                    var purchase = new PurchaseDetails();
                    purchase.itemid = ProductData.id;
                    purchase.purchase_price = Utils.ToNumbers(tbpurchaseprice.Text);
                    purchase.purchase_qty = int.Parse(numpurchaseqty.Text);
                    purchase.purchase_unit = cbunitpurchase.SelectedValue.ToString();

                    int prodstock = calculatestock();


                    if (purchaseRepository.AddwithStock(purchase, prodstock))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }

            }
            
        }

        private int calculatestock()
        {
            var selectedunit = ProdUnitList.FirstOrDefault(x => x.unitcode == cbunitpurchase.SelectedValue.ToString());
            var pcsunit = ProdUnitList.FirstOrDefault(x => x.pcsflag == "Y");

            int productstock = 0;

            if (selectedunit.pcsflag == "Y")
            {
                productstock = (int)numpurchaseqty.Value;

            }
            else if (ProductData.UnitRelated == "Y")
            {
                productstock = selectedunit.qty * (int)numpurchaseqty.Value;
                foreach (var item in ProdUnitList.OrderBy(x => x.seq))
                {
                    if (item.seq > selectedunit.seq && item.qty !=0)
                        productstock = productstock * item.qty;
                }
            }
            else
            {
                productstock = (int)numpurchaseqty.Value * selectedunit.qty;
            }

            return productstock;

        }

        private void tbpurchaseprice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                numpurchaseqty.Focus();
        }

        private void numpurchaseqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Apa Anda Yakin keluar tanpa menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}

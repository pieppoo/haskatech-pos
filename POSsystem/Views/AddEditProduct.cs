using POSsystem.Database;
using POSsystem.Model.Database;
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
    public partial class AddEditProduct : BaseForm
    {
        private ProductRepository productRepository = new ProductRepository();
        private BrandRepository brandRepository = new BrandRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private SellingPriceRepository sellingPriceRepository = new SellingPriceRepository();
        private ProductCategoryRepository categoryRepository = new ProductCategoryRepository();

        public List<Brand> BrandList { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<PurchaseDetails> PurchaseList { get; set; }
        public List<SellingPriceDetails> SellingPriceList { get; set; }
        public ProductDetails ProductData { get; set; }
        public List<ProductDetails> ProductList { get; set; }
        public List<ProductCategory> CategoriesList { get; set; }

        public AddEditProduct()
        {
            InitializeComponent();
        }

        public bool Editmode { get; set; }


        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            BrandList = brandRepository.GetAll();
            CategoriesList = categoryRepository.GetAll();
            UnitList = unitRepository.GetAll();

            

            cbbrand.DataSource = new BindingSource(BrandList, null);
            cbbrand.DisplayMember = "name";
            cbbrand.ValueMember = "id";

            cbprodcat.DataSource = new BindingSource(CategoriesList, null);
            cbprodcat.DisplayMember = "category_name";
            cbprodcat.ValueMember = "id";

            cbunitpcs.DataSource = new BindingSource(UnitList, null);
            cbunitpcs.DisplayMember = "description";
            cbunitpcs.ValueMember = "unitcode";


            if (Editmode)
            {
                cbbrand.SelectedValue = ProductData.brand_id;
                tbname.Text = ProductData.name;
                cbprodcat.SelectedValue = ProductData.prod_catetogry;
                cbunitpcs.SelectedValue = ProductData.unit_pcs;
                if (ProductData.UnitRelated == "Y")
                    rbyes.Checked = true;
                else if(ProductData.UnitRelated == "N")
                    rbnot.Checked = true;
                cbunitpcs.Enabled = false;
                gbradiobt.Enabled = false;
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {

            ProductList = productRepository.GetAll((int)cbbrand.SelectedValue);
            int samenameinsamebrand = 0;
            

            if (Editmode)
            {
                foreach (var existingname in ProductList)
                {
                    if (existingname.name == tbname.Text)
                    {
                        if (existingname.id != ProductData.id)
                            samenameinsamebrand += 1;
                    }
                        
                }


                if (tbname.Text == "")
                    MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
                else if (samenameinsamebrand > 0)
                {
                    MessageBox.Show("Tidak boleh memasukkan nama produk yang sama");
                    samenameinsamebrand = 0;
                }
                else
                {
                    ProductData.brand_id = (int)cbbrand.SelectedValue;
                    ProductData.name = tbname.Text;;
                    ProductData.prod_catetogry = (int)cbprodcat.SelectedValue;

                    if (productRepository.Update(ProductData))
                    {
                        MessageBox.Show("Data telah berhasil di ubah");
                        Close();
                    }
                    else
                        MessageBox.Show("Data gagal di ubah");
                }

            }
            else
            {
                foreach (var existingname in ProductList)
                {
                    if (existingname.name == tbname.Text)
                        samenameinsamebrand += 1;
                }

                if (tbname.Text == "")
                    MessageBox.Show(" Yang bertanda Bintang tidak boleh kosong");
                else if (samenameinsamebrand > 0)
                {
                    MessageBox.Show("Tidak boleh memasukkan nama produk yang sama");
                    samenameinsamebrand = 0;
                }
                else
                {
                    var product = new ProductDetails();
                    product.brand_id = (int)cbbrand.SelectedValue;
                    product.name = tbname.Text;
                    product.prod_catetogry = (int)cbprodcat.SelectedValue;
                    product.unit_pcs = cbunitpcs.SelectedValue.ToString();
                    if (rbyes.Checked)
                        product.UnitRelated = "Y";
                    else if(rbnot.Checked)
                        product.UnitRelated = "N";

                    if (!rbnot.Checked && !rbyes.Checked)
                        MessageBox.Show("Silahkan tentukan Produk kemasan berkaitan apa tidak");
                    else if (productRepository.Add(product))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }

            }
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btnSave.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Apa Anda Yakin keluar tanpa menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

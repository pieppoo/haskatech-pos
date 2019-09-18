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
    public partial class AddEditProduct : BaseForm
    {
        private ProductRepository productRepository = new ProductRepository();
        private BrandRepository brandRepository = new BrandRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private SellingPriceRepository sellingPriceRepository = new SellingPriceRepository();

        public List<Brand> BrandList { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<PurchaseDetails> PurchaseList { get; set; }
        public List<SellingPriceDetails> SellingPriceList { get; set; }
        public ProductDetails ProductData { get; set; }
        public List<ProductDetails> ProductList { get; set; }

        public AddEditProduct()
        {
            InitializeComponent();
        }

        public bool Editmode { get; set; }


        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            BrandList = brandRepository.GetAll();
            UnitList = unitRepository.GetAll();

            cbbrand.DataSource = new BindingSource(BrandList, null);
            cbbrand.DisplayMember = "name";
            cbbrand.ValueMember = "id";

            cbunitbulk.DataSource = new BindingSource(UnitList, null);
            cbunitbulk.DisplayMember = "description";
            cbunitbulk.ValueMember = "unitcode";

            cbunitpcs.DataSource = new BindingSource(UnitList, null);
            cbunitpcs.DisplayMember = "description";
            cbunitpcs.ValueMember = "unitcode";


            if (Editmode)
            {
                cbbrand.SelectedValue = ProductData.brand_id;
                tbname.Text = ProductData.name;
                cbunitbulk.SelectedValue = ProductData.unit_bulk;
                cbunitpcs.SelectedValue = ProductData.unit_pcs;
                nbqty.Value = ProductData.qty_pcs_in_container;

                PurchaseList = purchaseRepository.GetAll(ProductData.id);
                SellingPriceList = sellingPriceRepository.GetAll(ProductData.id);

                if (PurchaseList.Count != 0)
                {
                    cbunitbulk.Enabled = false;
                    cbunitpcs.Enabled = false;
                }

                if (SellingPriceList.Count != 0)
                {
                    cbunitbulk.Enabled = false;
                    cbunitpcs.Enabled = false;
                }

                nbqty.ReadOnly = true;
                nbqty.Enabled = false;

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

                    if (productRepository.Updatenameandbrand(ProductData))
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
                    MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
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
                    product.Stock = 0;
                    product.unit_bulk = cbunitbulk.SelectedValue.ToString();
                    product.unit_pcs = cbunitpcs.SelectedValue.ToString();


                    if (productRepository.Add(product))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }

            }
            
        }
    }
}

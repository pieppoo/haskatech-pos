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
        public List<Brand> BrandList { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public ProductDetails ProductData { get; set; }
        public AddEditProduct()
        {
            InitializeComponent();
        }

        public bool Editmode { get; set; }

        private void LoadBrand()
        {
            BrandList = brandRepository.GetAll();
        }

        private void LoadUnit()
        {
            UnitList = unitRepository.GetAll();
        }




        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            LoadBrand();
            LoadUnit();
            cbbrand.DataSource = new BindingSource(BrandList, null);
            cbbrand.DisplayMember = "name";
            cbbrand.ValueMember = "id";


            if (Editmode)
            {
                cbbrand.SelectedValue = ProductData.brand_id;
                tbname.Text = ProductData.name;
            }


        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (Editmode)
            {
                ProductData.brand_id = (int)cbbrand.SelectedValue;
                ProductData.name = tbname.Text;

                if (productRepository.Update(ProductData))
                    MessageBox.Show("Data telah berhasil di ubah");
                else
                    MessageBox.Show("Data gagal di ubah");
            }
            else
            {
                var product = new ProductDetails();
                product.brand_id = (int)cbbrand.SelectedValue;
                product.name = tbname.Text;


                if (productRepository.Add(product))
                    MessageBox.Show("Data baru telah berhasil di tambahkan");
                else
                    MessageBox.Show("Data baru gagal ditambahkan");
            }
            Close();
        }
    }
}

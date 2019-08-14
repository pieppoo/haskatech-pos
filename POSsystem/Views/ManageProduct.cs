using POSsystem.Database;
using POSsystem.Repository;
using POSsystem.Views;
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


namespace POSsystem
{
    public partial class ManageProduct : BaseForm
    {
        public List<ProductDetails> ProductList { get; set; }
        public List<Brand> BrandList { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private BrandRepository brandRepository = new BrandRepository();

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btunitmanagement_Click(object sender, EventArgs e)
        {
            var form = new ManageBrand();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void LoadData()
        {
            BrandList = brandRepository.GetAll().ToList(); ;
            ProductList = productRepository.GetAll().OrderBy(x => x.id).ThenBy(x => x.name).ToList();

            gvitem.Rows.Clear();

            foreach (var item in ProductList)
            {
                var brand = BrandList.FirstOrDefault(x => x.id == item.brand_id);

                gvitem.Rows.Add(
                    item.id,
                    brand != null ? brand.name :  " - ",
                    item.name
                    );
                
            }


            var cbData = BrandList;
            cbData.Insert(0, new Brand { id = -1, name = "--- Pilih Brand ---" });

            cbbrand.DataSource = new BindingSource(BrandList, null);
            cbbrand.DisplayMember = "name";
            cbbrand.ValueMember = "id";
        }

        private void btadditem_Click(object sender, EventArgs e)
        {
            var form = new AddEditProduct();
            form.ShowDialog();
            LoadData();
        }

        private void btedititem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvitem.Rows[gvitem.CurrentCell.RowIndex].Cells[0].Value);
            var product = ProductList.FirstOrDefault(x => x.id == id);
            if (product != null)
            {
                var form = new AddEditProduct();
                form.Editmode = true;
                form.ProductData = product;
                form.ShowDialog();
                LoadData();
            }

        }

        private void btdeleteitem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvitem.Rows[gvitem.CurrentCell.RowIndex].Cells[0].Value);
            
            var form = new ConfirmationDialog();
            form.Message = "Apa anda yakin menghapus produk terpilih?";
            form.ShowDialog();

            if (form.YES)
            {
                    
                if (!productRepository.Delete(id))
                    MessageBox.Show("Gagal menghapus brand");
                LoadData();
            }

        }

        private void gvitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(gvitem.Rows[e.RowIndex].Cells[0].Value);
            var product = ProductList.FirstOrDefault(x => x.id == id);

            if (product != null)
            {
                var form = new ManagePurchase();
                form.ProductData = product;
                form.ShowDialog();
                LoadData();
            }
        }

        private void btunitmanage_Click(object sender, EventArgs e)
        {
            var form = new ManageUnit();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            var args = new List<object>();

            if (!string.IsNullOrEmpty(tbitemname.Text))
            {
                args.Add(tbitemname.Text);
            }

            if((int)cbbrand.SelectedValue != -1)
            {
                args.Add((int)cbbrand.SelectedValue);
            }

            var result = productRepository.Search(args.ToArray());

            if(result != null)
            {
                gvitem.Rows.Clear();

                foreach (var item in result)
                {
                    var brand = BrandList.FirstOrDefault(x => x.id == item.brand_id);

                    gvitem.Rows.Add(
                        item.id,
                        brand != null ? brand.name : " - ",
                        item.name
                        );

                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbitemname.Clear();
        }

        private void tbitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btsearch.PerformClick();
            }
        }
    }
}

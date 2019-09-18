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
        public List<UnitItem> UnitList { get; set; }
        public LoginDetails userdata { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private BrandRepository brandRepository = new BrandRepository();
        private UnitRepository unitRepository = new UnitRepository();



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
            LoadData();
        }

        private void LoadData()
        {
            if (userdata.user_role == "kasir")
            {
                btadditem.Visible = false;
                btedititem.Visible = false;
                btdeleteitem.Visible = false;
                btunitmanage.Visible = false;
                btmanagebrand.Visible = false;
            }

            try
            {
                BrandList = brandRepository.GetAll().ToList();
                ProductList = productRepository.GetAll().OrderBy(x => x.id).ThenBy(x => x.name).ToList();
                UnitList = unitRepository.GetAll();

                gvitem.Rows.Clear();


                foreach (var item in ProductList)
                {
                    var brand = BrandList.FirstOrDefault(x => x.id == item.brand_id);
                    var unitbulkinfo = UnitList.FirstOrDefault(x => x.unitcode == item.unit_bulk);
                    var unitpcsinfo = UnitList.FirstOrDefault(x => x.unitcode == item.unit_pcs);

                    int stockbulk = (item.Stock / item.qty_pcs_in_container);
                    int stockpcs = item.Stock - (stockbulk * item.qty_pcs_in_container);
                    var itemstock = stockbulk + " " + unitbulkinfo.description + " " + stockpcs + " " + unitpcsinfo.description; 


                    gvitem.Rows.Add(
                        item.id,
                        brand != null ? brand.name : " - ",
                        item.name,
                        unitbulkinfo != null ? unitbulkinfo.description : " - ",
                        unitpcsinfo != null ? unitpcsinfo.description : " - ",
                        itemstock,
                        item.qty_pcs_in_container
                        );

                }


                var cbData = BrandList;
                cbData.Insert(0, new Brand { id = -1, name = "--- Pilih Brand ---" });

                cbbrand.DataSource = new BindingSource(BrandList, null);
                cbbrand.DisplayMember = "name";
                cbbrand.ValueMember = "id";
            }
            catch (Exception ex)
            {
                var errMsg = "Details : " + ex.Message + Environment.NewLine + "Stacktrace : " + ex.StackTrace;
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btadditem_Click(object sender, EventArgs e)
        {
            var form = new AddEditProduct();
            form.ShowDialog();
            LoadData();
        }

        private void btedititem_Click(object sender, EventArgs e)
        {
            if (gvitem.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada produk yang akan diubah");
            else
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

        }

        private void btdeleteitem_Click(object sender, EventArgs e)
        {
            if (gvitem.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada produk yang akan dihapus");
            else
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


        }

        private void gvitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userdata.user_role == "admin")
            {
                var id = Convert.ToInt32(gvitem.Rows[e.RowIndex].Cells[0].Value);
                var product = ProductList.FirstOrDefault(x => x.id == id);

                if (product != null)
                {
                    var form = new ManagePurchase();
                    form.ProductData = product;
                    Hide();
                    form.ShowDialog();
                    Show();
                    LoadData();
                }
            }

        }

        private void btunitmanage_Click(object sender, EventArgs e)
        {
            var form = new ManageUnit();
            Hide();
            form.ShowDialog();
            Show();
            LoadData();
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
                    var unitbulkinfo = UnitList.FirstOrDefault(x => x.unitcode == item.unit_bulk);
                    var unitpcsinfo = UnitList.FirstOrDefault(x => x.unitcode == item.unit_pcs);

                    gvitem.Rows.Add(
                        item.id,
                        brand != null ? brand.name : " - ",
                        item.name,
                        unitbulkinfo != null ? unitbulkinfo.description : " - ",
                        unitpcsinfo != null ? unitpcsinfo.description : " - ",
                        item.Stock
                        );

                }
            }
            else
                MessageBox.Show("Barang tidak ditemukan");
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

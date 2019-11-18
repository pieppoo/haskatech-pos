using POSsystem.Database;
using POSsystem.Model;
using POSsystem.Model.Database;
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
        public List<ProductCategory> CategoriesList { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private BrandRepository brandRepository = new BrandRepository();
        private ProductCategoryRepository categoryRepository = new ProductCategoryRepository();
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        private UnitRepository unitRepository = new UnitRepository();
        


        public ManageProduct()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
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
                ProductList = productRepository.GetAll().ToList();
                CategoriesList = categoryRepository.GetAll().ToList();
                UnitList = unitRepository.GetAll().ToList();
                var tempproductlist = new List<TempProductDetails>();
                var unitproduct = new List<ProductUnitsDetails>();

                if (ProductList != null)
                {
                    foreach (var item in ProductList)
                    {
                        var pcsunit = new ProductUnitsDetails();
                        unitproduct = productUnitsRepository.GetAll(item.id);
                        if (unitproduct.Count > 0)
                        {
                            pcsunit = unitproduct.FirstOrDefault(x => x.pcsflag == "Y");
                        }
                            
                       
                        var brand = BrandList.FirstOrDefault(x => x.id == item.brand_id);
                        var prodcat = CategoriesList.FirstOrDefault(x => x.id == item.prod_catetogry);
                        var selectedunit = UnitList.FirstOrDefault(x => x.unitcode == pcsunit.unitcode);

                        var itemDetail = new TempProductDetails();
                        itemDetail.id = item.id;
                        itemDetail.brand_id = item.brand_id;
                        itemDetail.name = item.name;
                        itemDetail.brandname = brand != null ? brand.name : " - ";
                        itemDetail.prod_catetogry = item.prod_catetogry;
                        itemDetail.prodcat_name = prodcat != null ? prodcat.category_name : " - ";
                        itemDetail.Stock = selectedunit != null ? item.Stock + " " + selectedunit.description : item.Stock.ToString();
                        tempproductlist.Add(itemDetail);
                    }

                    gvitem.Rows.Clear();

                    foreach (var item in tempproductlist.OrderBy(x => x.prodcat_name).ThenBy(x => x.brandname).ThenBy(x => x.name))
                    {
                        gvitem.Rows.Add(
                            item.id,
                            item.prodcat_name,
                            item.brandname,
                            item.name,
                            item.Stock
                            );
                    }
                }



                var cbData = BrandList;
                cbData.Insert(0, new Brand { id = -1, name = "--- Pilih Merek ---" });

                cbbrand.DataSource = new BindingSource(BrandList, null);
                cbbrand.DisplayMember = "name";
                cbbrand.ValueMember = "id";

                var cbcatdata = CategoriesList;
                cbcatdata.Insert(0, new ProductCategory { id = -1, category_name = "--- Pilih Kategori ---" });

                cbcategory.DataSource = new BindingSource(CategoriesList, null);
                cbcategory.DisplayMember = "category_name";
                cbcategory.ValueMember = "id";
            }
            catch (Exception ex)
            {
                var errMsg = "Details : " + ex.Message + Environment.NewLine + "Stacktrace : " + ex.StackTrace;
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbitemname.Focus();
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

                    var unitproduct = new List<ProductUnitsDetails>();
                    unitproduct = productUnitsRepository.GetAll(id);

                    var pcsunit = new ProductUnitsDetails();

                    if (unitproduct.Count > 0)
                    {
                        pcsunit = unitproduct.FirstOrDefault(x => x.pcsflag == "Y");
                    }

                    var updatedProduct = ProductList.FirstOrDefault(x => x.id == id);
                    var brand = BrandList.FirstOrDefault(x => x.id == updatedProduct.brand_id);
                    var prodcat = CategoriesList.FirstOrDefault(x => x.id == updatedProduct.prod_catetogry);
                    var selectedunit = UnitList.FirstOrDefault(x => x.unitcode == pcsunit.unitcode);


                    gvitem.Rows.RemoveAt(gvitem.CurrentCell.RowIndex);
                    gvitem.Rows.Insert(gvitem.CurrentCell.RowIndex,
                        updatedProduct.id,
                        prodcat != null ? prodcat.category_name : " - ",
                        brand != null ? brand.name : " - " ,
                        updatedProduct.name,
                        selectedunit != null ? updatedProduct.Stock + " " + selectedunit.description : updatedProduct.Stock.ToString());
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
                        MessageBox.Show("Gagal menghapus produk");
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

                    var unitproduct = new List<ProductUnitsDetails>();
                    unitproduct = productUnitsRepository.GetAll(id);
                    ProductList = productRepository.GetAll();

                    var pcsunit = new ProductUnitsDetails();

                    if (unitproduct.Count > 0)
                    {
                        pcsunit = unitproduct.FirstOrDefault(x => x.pcsflag == "Y");
                    }

                    var updatedProduct = ProductList.FirstOrDefault(x => x.id == id);
                    var brand = BrandList.FirstOrDefault(x => x.id == updatedProduct.brand_id);
                    var prodcat = CategoriesList.FirstOrDefault(x => x.id == updatedProduct.prod_catetogry);
                    var selectedunit = UnitList.FirstOrDefault(x => x.unitcode == pcsunit.unitcode);

                    gvitem.Rows.RemoveAt(gvitem.CurrentCell.RowIndex);
                    gvitem.Rows.Insert(gvitem.CurrentCell.RowIndex,
                        updatedProduct.id,
                        prodcat != null ? prodcat.category_name : " - ",
                        brand != null ? brand.name : " - ",
                        updatedProduct.name,
                        selectedunit != null ? updatedProduct.Stock + " " + selectedunit.description : updatedProduct.Stock.ToString());

                    Show();
                }
            }

        }

        private void gvitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (userdata.user_role == "admin")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (gvitem.Rows.Count > 0)
                    {
                        int currIndex = gvitem.CurrentRow.Index;
                        var id = Convert.ToInt32(gvitem.Rows[currIndex].Cells[0].Value);
                        var product = ProductList.FirstOrDefault(x => x.id == id);


                        if (product != null)
                        {
                            var form = new ManagePurchase();
                            form.ProductData = product;
                            Hide();
                            form.ShowDialog();

                            var unitproduct = new List<ProductUnitsDetails>();
                            unitproduct = productUnitsRepository.GetAll(id);
                            ProductList = productRepository.GetAll();

                            var pcsunit = new ProductUnitsDetails();

                            if (unitproduct.Count > 0)
                            {
                                pcsunit = unitproduct.FirstOrDefault(x => x.pcsflag == "Y");
                            }

                            var updatedProduct = ProductList.FirstOrDefault(x => x.id == id);
                            var brand = BrandList.FirstOrDefault(x => x.id == updatedProduct.brand_id);
                            var prodcat = CategoriesList.FirstOrDefault(x => x.id == updatedProduct.prod_catetogry);
                            var selectedunit = UnitList.FirstOrDefault(x => x.unitcode == pcsunit.unitcode);

                            gvitem.Rows.RemoveAt(gvitem.CurrentCell.RowIndex);
                            gvitem.Rows.Insert(gvitem.CurrentCell.RowIndex,
                                updatedProduct.id,
                                prodcat != null ? prodcat.category_name : " - ",
                                brand != null ? brand.name : " - ",
                                updatedProduct.name,
                                selectedunit != null ? updatedProduct.Stock + " " + selectedunit.description : updatedProduct.Stock.ToString());

                            Show();
                        }
                    }

                }
            }


        }
        private void bcategory_Click(object sender, EventArgs e)
        {
            var form = new ManageCategories();
            Hide();
            form.ShowDialog();
            Show();
            LoadData();
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

            /*
            var args = new List<object>();
            if (!string.IsNullOrEmpty(tbitemname.Text))
            {
                args.Add(tbitemname.Text);
            }

            if((int)cbbrand.SelectedValue != -1)
            {
                args.Add((int)cbbrand.SelectedValue);
            }

            if ((int)cbcategory.SelectedValue != -1)
            {
                args.Add((int)cbcategory.SelectedValue);
            }

            var result = productRepository.Search(args.ToArray());
            */

            var itemname = tbitemname.Text;
            int brandid = (int)cbbrand.SelectedValue;
            int catid = ((int)cbcategory.SelectedValue);

            if (brandid == -1)
                brandid = 0;
            if (catid == -1)
                catid = 0;

            if (itemname.Length > 0 || brandid > 0 || catid > 0)
            {
                var result = productRepository.SearchProd(itemname, brandid, catid);
                if (result != null)
                {
                    var tempproductlist = new List<TempProductDetails>();
                    var unitproduct = new List<ProductUnitsDetails>();

                    foreach (var item in result)
                    {
                        var pcsunit = new ProductUnitsDetails();
                        unitproduct = productUnitsRepository.GetAll(item.id);
                        if (unitproduct.Count > 0)
                        {
                            pcsunit = unitproduct.FirstOrDefault(x => x.pcsflag == "Y");
                        }

                        var brand = BrandList.FirstOrDefault(x => x.id == item.brand_id);
                        var prodcat = CategoriesList.FirstOrDefault(x => x.id == item.prod_catetogry);
                        var selectedunit = UnitList.FirstOrDefault(x => x.unitcode == pcsunit.unitcode);

                        var itemDetail = new TempProductDetails();
                        itemDetail.id = item.id;
                        itemDetail.brand_id = item.brand_id;
                        itemDetail.name = item.name;
                        itemDetail.brandname = brand != null ? brand.name : " - ";
                        itemDetail.prod_catetogry = item.prod_catetogry;
                        itemDetail.prodcat_name = prodcat != null ? prodcat.category_name : " - ";
                        itemDetail.Stock =  selectedunit != null ? item.Stock + " " + selectedunit.description : item.Stock.ToString();
                        tempproductlist.Add(itemDetail);
                    }

                    gvitem.Rows.Clear();

                    foreach (var item in tempproductlist.OrderBy(x => x.prodcat_name).ThenBy(x => x.brandname).ThenBy(x => x.name))
                    {
                        gvitem.Rows.Add(
                            item.id,
                            item.prodcat_name,
                            item.brandname,
                            item.name,
                            item.Stock
                            );
                    }
                }
                else
                    MessageBox.Show("Barang tidak ditemukan");
            }


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbitemname.Clear();
            tbitemname.Focus();
        }

        private void tbitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btsearch.PerformClick();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                tbitemname.Focus();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                cbbrand.Focus();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btsearch.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                btnreset.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F5))
            {
                btadditem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F6))
            {
                btedititem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F7))
            {
                btdeleteitem.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F8))
            {
                btmanagebrand.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F9))
            {
                btunitmanage.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F10))
            {
                btcategory.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Space))
            {
                gvitem.Focus();
                return true;
            }
            else if (keyData == (Keys.Q))
            {
                tbitemname.Focus();
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

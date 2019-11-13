using POSsystem.Database;
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

namespace POSsystem.Views
{
    public partial class ManageCategories : BaseForm
    {
        public List<ProductCategory> Categorieslist { get; set; }

        private ProductCategoryRepository categoryRepository = new ProductCategoryRepository();

        public ManageCategories()
        {
            InitializeComponent();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            LoadData();

            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void LoadData()
        {
            Categorieslist = categoryRepository.GetAll();

            gvcat.Rows.Clear();

            int runningno = 1;

            foreach (var item in Categorieslist)
            {

                gvcat.Rows.Add(item.id,
                    runningno,
                    item.category_name,
                    item.remark);

                runningno = runningno + 1;
            }

            runningno = 1;
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            var args = new List<object>();

            if (!string.IsNullOrEmpty(tbcatname.Text))
            {
                args.Add(tbcatname.Text);
            }

            var result = categoryRepository.Search(args.ToArray());

            if (result != null)
            {
                gvcat.Rows.Clear();
                int runningno = 1;

                foreach (var item in result)
                {

                    gvcat.Rows.Add(item.id,
                        runningno,
                        item.category_name,
                        item.remark);
                    runningno = runningno + 1;
                }
                runningno = 1;
            }
            else
                MessageBox.Show("Barang tidak ditemukan");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbcatname.Clear();
            tbcatname.Focus();
        }

        private void btdelcat_Click(object sender, EventArgs e)
        {
            if (gvcat.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada kategori yang akan dihapus");
            else
            {
                var id = Convert.ToInt32(gvcat.Rows[gvcat.CurrentCell.RowIndex].Cells["id"].Value);

                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus Kategori terpilih?";
                form.ShowDialog();

                if (form.YES)
                {
                    if (!categoryRepository.Delete(id))
                        MessageBox.Show("Gagal menghapus Kategori");
                    LoadData();
                }
            }
        }

        private void btaddcat_Click(object sender, EventArgs e)
        {
            var form = new AddEditCategories();
            form.ShowDialog();
            LoadData();
        }

        private void bteditcat_Click(object sender, EventArgs e)
        {
            if (gvcat.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada Kategori yang akan diubah");
            else
            {
                var id = Convert.ToInt32(gvcat.Rows[gvcat.CurrentCell.RowIndex].Cells["id"].Value);
                var prodcat = Categorieslist.FirstOrDefault(x => x.id == id);
                if (prodcat != null)
                {
                    var form = new AddEditCategories();
                    form.Editmode = true;
                    form.CategoryData = prodcat;
                    form.ShowDialog();
                    LoadData();
                }
            }
        }

        private void gvcat_DoubleClick(object sender, EventArgs e)
        {
            if (gvcat.Rows.Count > 0)
            {
                bteditcat.PerformClick();
            }
        }

        private void gvcat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gvcat.Rows.Count > 0)
                {
                    bteditcat.PerformClick();
                }
            }
        }

        private void tbcatname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btsearch.PerformClick();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btaddcat.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                bteditcat.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btdelcat.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                btsearch.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F5))
            {
                btnreset.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Delete))
            {
                btdelcat.PerformClick();
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

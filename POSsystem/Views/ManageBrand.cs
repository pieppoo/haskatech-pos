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
    public partial class ManageBrand : BaseForm
    {
        public List<Brand> BrandList { get; set; }

        private BrandRepository brandRepository = new BrandRepository();
        public ManageBrand()
        {
            InitializeComponent();
        }


        private void ManageBrand_Load(object sender, EventArgs e)
        {
            LoadData();

            /*
            Console.WriteLine("single data");
            Console.WriteLine(List[0].ID);
            Console.WriteLine(List[0].name);
            Console.WriteLine(List[0].remark);
            */
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
            BrandList = brandRepository.GetAll();

            gvbrand.Rows.Clear();

            int runningno = 1;

            foreach (var item in BrandList)
            {

                gvbrand.Rows.Add(item.id,
                    runningno,
                    item.name,
                    item.remark);

                runningno = runningno + 1;
            }

            runningno = 1;
        }

        private void btaddbrand_Click(object sender, EventArgs e)
        {
            var form = new AddEditBrand();
            form.ShowDialog();
            LoadData();
        }

        private void bteditbrand_Click(object sender, EventArgs e)
        {
            if (gvbrand.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada merek yang akan diubah");
            else
            {
                var id = Convert.ToInt32(gvbrand.Rows[gvbrand.CurrentCell.RowIndex].Cells[0].Value);
                var brand = BrandList.FirstOrDefault(x => x.id == id);
                if (brand != null)
                {
                    var form = new AddEditBrand();
                    form.Editmode = true;
                    form.Branddata = brand;
                    form.ShowDialog();
                    LoadData();
                }
            }

        }

        private void btdeletebrand_Click(object sender, EventArgs e)
        {
            if (gvbrand.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada merek yang akan dihapus");
            else
            {
                var id = Convert.ToInt32(gvbrand.Rows[gvbrand.CurrentCell.RowIndex].Cells[0].Value);

                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus Merek terpilih?";
                form.ShowDialog();

                if (form.YES)
                {
                    if (!brandRepository.Delete(id))
                        MessageBox.Show("Gagal menghapus Merek");
                    LoadData();
                }
            }

        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            var args = new List<object>();

            if (!string.IsNullOrEmpty(tbbrandname.Text))
            {
                args.Add(tbbrandname.Text);
            }

            var result = brandRepository.Search(args.ToArray());

            if (result.Count != 0)
            {
                gvbrand.Rows.Clear();
                int runningno = 1;

                foreach (var item in result)
                {

                    gvbrand.Rows.Add(item.id,
                        runningno,
                        item.name,
                        item.remark);
                    runningno = runningno + 1;
                }
                runningno = 1;
            }
            else
                MessageBox.Show("Barang tidak ditemukan");
        }

        private void gvbrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gvbrand.Rows.Count > 0)
                {
                    bteditbrand.PerformClick();
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbbrandname.Clear();
            tbbrandname.Focus();

        }

        private void tbbrandname_KeyDown(object sender, KeyEventArgs e)
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
                btaddbrand.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                bteditbrand.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btdeletebrand.PerformClick();
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
                btdeletebrand.PerformClick();
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

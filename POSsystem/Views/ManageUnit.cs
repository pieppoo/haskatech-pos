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

namespace POSsystem.Views
{
    public partial class ManageUnit : BaseForm
    {
        public List<UnitItem> UnitList { get; set; }

        private UnitRepository unitRepository = new UnitRepository();
        public ManageUnit()
        {
            InitializeComponent();
        }

        private void ManageUnit_Load(object sender, EventArgs e)
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


        private void LoadData()
        {
            UnitList = unitRepository.GetAll().OrderBy(x => x.unitcode).ThenBy(x => x.description).ToList();
            gvunititem.Rows.Clear();
            int runningno = 1;

            foreach (var item in UnitList)
            {
                gvunititem.Rows.Add(
                    item.id,
                    runningno,
                    item.unitcode,
                    item.description);

                runningno += 1;
            }
            runningno = 1;
        }

        private void btaddunit_Click(object sender, EventArgs e)
        {
            var form = new AddEditUnit();
            form.ShowDialog();
            LoadData();
        }

        private void bteditunit_Click(object sender, EventArgs e)
        {
            if (gvunititem.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada kemasan yang akan diubah");
            else
            {
                var id = Convert.ToInt32(gvunititem.Rows[gvunititem.CurrentCell.RowIndex].Cells[0].Value);
                var unitselected = UnitList.FirstOrDefault(x => x.id == id);
                if (unitselected != null)
                {
                    var form = new AddEditUnit();
                    form.Editmode = true;
                    form.UnitData = unitselected;
                    form.ShowDialog();
                    LoadData();
                }
            }

        }

        private void btdeleteunit_Click(object sender, EventArgs e)
        {
            if (gvunititem.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada kemasan yang akan dihapus");
            else
            {
                var id = Convert.ToInt32(gvunititem.Rows[gvunititem.CurrentCell.RowIndex].Cells[0].Value);

                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus Kemasan terpilih?";
                form.ShowDialog();

                if (form.YES)
                {
                    if (!unitRepository.Delete(id))
                        MessageBox.Show("Gagal menghapus Kemasan");
                    LoadData();
                }
            }

        }

        private void gvunititem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bteditunit.PerformClick();
        }

        private void gvunititem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gvunititem.Rows.Count > 0)
                {
                    bteditunit.PerformClick();
                }
            }
        }

        private void tbunitname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btsearch.PerformClick();
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            var args = new List<object>();

            if (!string.IsNullOrEmpty(tbunitname.Text))
            {
                args.Add(tbunitname.Text);

                var result = unitRepository.Search(args.ToArray());

                if (result.Count != 0)
                {
                    gvunititem.Rows.Clear();
                    int runningno = 1;

                    foreach (var item in result)
                    {

                        gvunititem.Rows.Add(item.id,
                            runningno,
                            item.unitcode,
                            item.description);
                        runningno = runningno + 1;
                    }
                    runningno = 1;
                }
                else
                    MessageBox.Show("Kemasan tidak ditemukan");
            }

            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadData();
            tbunitname.Clear();
            tbunitname.Focus();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btaddunit.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                bteditunit.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btdeleteunit.PerformClick();
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
                btdeleteunit.PerformClick();
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

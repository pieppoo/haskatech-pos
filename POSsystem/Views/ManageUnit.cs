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
            LoadData();
        }

        private void LoadData()
        {
            UnitList = unitRepository.GetAll().OrderBy(x => x.description).ToList();

            gvunititem.Rows.Clear();

            foreach (var item in UnitList)
            {
                gvunititem.Rows.Add(
                    item.id,
                    item.unitcode,
                    item.description);

            }
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
                form.Message = "Apa anda yakin menghapus Brand terpilih?";
                form.ShowDialog();

                if (form.YES)
                {
                    if (!unitRepository.Delete(id))
                        MessageBox.Show("Gagal menghapus brand");
                    LoadData();
                }
            }

        }
    }
}

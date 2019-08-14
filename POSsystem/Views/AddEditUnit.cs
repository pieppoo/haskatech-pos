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
    public partial class AddEditUnit : BaseForm
    {
        private UnitRepository unitRepository = new UnitRepository();
        public UnitItem UnitData { get; set; }
        public bool Editmode { get; set; }
        public AddEditUnit()
        {
            InitializeComponent();
        }

        private void AddEditUnit_Load(object sender, EventArgs e)
        {
            if(Editmode)
            {
                tbunitcode.Text = UnitData.unitcode;
                tbunitname.Text = UnitData.description;
                tbunitcode.ReadOnly = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Editmode)
            {
                UnitData.unitcode = tbunitcode.Text;
                UnitData.description  = tbunitname.Text;

                if (unitRepository.Update(UnitData))
                    MessageBox.Show("Data telah berhasil di ubah");
                else
                    MessageBox.Show("Data gagal di ubah");
            }
            else
            {
                var unitdetails = new UnitItem();
                unitdetails.unitcode = tbunitcode.Text;
                unitdetails.description = tbunitname.Text;

                if (unitRepository.Add(unitdetails))
                    MessageBox.Show("Data baru telah berhasil di tambahkan");
                else
                    MessageBox.Show("Data baru gagal ditambahkan");
            }
            Close();
            

        }
    }
}

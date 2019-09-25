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
        public List<UnitItem> UnitList { get; set; }
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
            UnitList = unitRepository.GetAll();
            int samenameorcode = 0;


            if (tbunitcode.Text == "")
                MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
            else if (tbunitname.Text == "")
                MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
            else
            {
                if (Editmode)
                {
                    UnitData.unitcode = tbunitcode.Text;
                    UnitData.description = tbunitname.Text;

                    foreach (var existingunit in UnitList)
                    {
                        if (tbunitcode.Text == existingunit.unitcode)
                            samenameorcode += 1;
                        else if (tbunitname.Text == existingunit.description)
                            samenameorcode += 1;
                    }

                    if (samenameorcode > 1)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama atau kode kemasan yang sama");
                        samenameorcode = 0;
                    }
                    else if (unitRepository.Update(UnitData))
                    {
                        MessageBox.Show("Data telah berhasil di ubah");
                        Close();
                    }
                    else
                        MessageBox.Show("Data gagal di ubah");
                }
                else
                {
                    var unitdetails = new UnitItem();
                    unitdetails.unitcode = tbunitcode.Text;
                    unitdetails.description = tbunitname.Text;

                    foreach (var existingunit in UnitList)
                    {
                        if (tbunitcode.Text == existingunit.unitcode)
                            samenameorcode += 1;
                        else if (tbunitname.Text == existingunit.description)
                            samenameorcode += 1;
                    }

                    if (samenameorcode > 0)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama atau kode kemasan yang sama");
                        samenameorcode = 0;
                    }
                    else if (unitRepository.Add(unitdetails))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }
                
            }

            
            

        }

        private void tbunitcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbunitname.Focus();
        }

        private void tbunitname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}

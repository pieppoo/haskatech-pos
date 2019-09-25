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

namespace POSsystem
{
    public partial class AddEditBrand : BaseForm
    {
        private BrandRepository brandRepository = new BrandRepository();

        public Brand Branddata { get; set; }
        public List<Brand> BrandList { get; set; }

        public bool Editmode { get; set; }

        public AddEditBrand()
        {
            InitializeComponent();
        }


        private void btsave_Click(object sender, EventArgs e)
        {
            BrandList = brandRepository.GetAll();

            if (tbbrandname.Text == "")
            {
                MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
            }
            else
            {
                int samename = 0;

                if (Editmode)
                {
                    Branddata.name = tbbrandname.Text;
                    Branddata.remark = tbremark.Text;


                    foreach (var existbrand in BrandList)
                    {
                        if (tbbrandname.Text == existbrand.name)
                        {
                                if (existbrand.id != Branddata.id)
                                    samename += 1;
                        }
                    }

                    if (samename > 0)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama merek yang sama");
                        samename = 0;
                    }
                    else if (brandRepository.Update(Branddata))
                    {
                        MessageBox.Show("Data telah berhasil di ubah");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                    

                }
                else
                {
                    var brand = new Brand();
                    brand.name = tbbrandname.Text;
                    brand.remark = tbremark.Text;


                    foreach (var existbrand in BrandList)
                    {
                        if ( tbbrandname.Text == existbrand.name)
                            samename = samename +  1;
                    }

                    if (samename > 0)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama merek yang sama");
                        samename = 0;
                    }
                    else if (brandRepository.Add(brand))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }
            }


            

        }


        private void AddEditBrand_Load(object sender, EventArgs e)
        {

            if (Editmode)
            {
                tbbrandname.Text = Branddata.name;
                tbremark.Text = Branddata.remark;
             }
        }

        private void tbbrandname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        private void tbremark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Apa Anda Yakin keluar tanpa menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

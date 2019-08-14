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

        public bool Editmode { get; set; }

        public AddEditBrand()
        {
            InitializeComponent();
        }


        private void btsave_Click(object sender, EventArgs e)
        {
            

            if (Editmode)
            {
                Branddata.name = tbbrandname.Text;
                Branddata.remark = tbremark.Text;

                if (brandRepository.Update(Branddata))
                    MessageBox.Show("Data telah berhasil di ubah");
                else
                    MessageBox.Show("Data gagal di ubah");
            }
           else
            {
                var brand = new Brand();
                brand.name = tbbrandname.Text;
                brand.remark = tbremark.Text;
                

                if (brandRepository.Add(brand))
                    MessageBox.Show("Data baru telah berhasil di tambahkan");
                else
                    MessageBox.Show("Data baru gagal ditambahkan");
                
            }

            Close();

        }

        private void AddEditBrand_Load(object sender, EventArgs e)
        {
            if (Editmode)
            {
                tbbrandname.Text = Branddata.name;
                tbremark.Text = Branddata.remark;
             }
        }
    }
}

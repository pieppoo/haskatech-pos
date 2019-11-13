using POSsystem.Database;
using POSsystem.Model.Database;
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

namespace POSsystem.Views
{
    public partial class AddEditCategories : BaseForm
    {
        public List<ProductCategory> Categorieslist { get; set; }
        public ProductCategory CategoryData { get; set; }
        public bool Editmode { get; set; }

        private ProductCategoryRepository categoryRepository = new ProductCategoryRepository();

        public AddEditCategories()
        {
            InitializeComponent();
        }

        private void AddEditCategories_Load(object sender, EventArgs e)
        {
            if (Editmode)
            {
                tbcatname.Text = CategoryData.category_name;
                tbremark.Text = CategoryData.remark;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categorieslist = categoryRepository.GetAll();

            if (tbcatname.Text == "")
            {
                MessageBox.Show("Yang bertanda Bintang tidak boleh kosong");
            }
            else
            {
                int samename = 0;

                if (Editmode)
                {
                    CategoryData.category_name = tbcatname.Text;
                    CategoryData.remark = tbremark.Text;


                    foreach (var existcategory in Categorieslist)
                    {
                        if (tbcatname.Text == existcategory.category_name)
                        {
                            if (existcategory.id != CategoryData.id)
                                samename += 1;
                        }
                    }

                    if (samename > 0)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama kategori yang sama");
                        samename = 0;
                    }
                    else if (categoryRepository.Update(CategoryData))
                    {
                        MessageBox.Show("Data telah berhasil di ubah");
                        Close();
                    }
                    else
                        MessageBox.Show("Data gagal diubah");


                }
                else
                {
                    var prodcat = new ProductCategory();
                    prodcat.category_name = tbcatname.Text;
                    prodcat.remark = tbremark.Text;


                    foreach (var existprodcat in Categorieslist)
                    {
                        if (tbcatname.Text == existprodcat.category_name)
                            samename = samename + 1;
                    }

                    if (samename > 0)
                    {
                        MessageBox.Show("Tidak boleh memasukkan nama kategori yang sama");
                        samename = 0;
                    }
                    else if (categoryRepository.Add(prodcat))
                    {
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }
            }
        }

        private void tbcatname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbremark.Focus();
        }

        private void tbremark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
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

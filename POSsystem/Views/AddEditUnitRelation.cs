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


namespace POSsystem.Views
{
    public partial class AddEditUnitRelation : Form
    {
        public ProductDetails ProductData { get; set; }
        public List<UnitItem> unitList { get; set; }
        public ProductDetails SelectedProduct { get; set; }

        private UnitRepository unitRepository = new UnitRepository();
        private ProductRepository productRepository = new ProductRepository();
        public AddEditUnitRelation()
        {
            InitializeComponent();
        }

        private void AddEditUnitRelation_Load(object sender, EventArgs e)
        {
            lbitemname.Text = ProductData.name;
            if (ProductData.UnitRelated == "Y")
                rbyes.Checked = true;
            else
                rbno.Checked = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rbno.Checked && !rbyes.Checked)
            {
                MessageBox.Show("Silahkan tentuka pilihan anda pada unit berkaitan apa tidak");
            }
            else
            {
                if (rbyes.Checked)
                    ProductData.UnitRelated = "Y";
                else
                {
                    ProductData.UnitRelated = "N";
                }

                if (productRepository.UpdateProductUnit(ProductData.id, ProductData.UnitRelated))
                {
                    MessageBox.Show("Data telah berhasil di ubah");
                    Close();
                }
                else
                    MessageBox.Show("Data gagal diubah");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

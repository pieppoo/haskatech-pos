using System;
using System.Windows.Forms;

namespace POSsystem.Views
{
    public partial class ConfirmationDialog : Form
    {
        public string Message
        {
            set
            {
                lbmessage.Text = value;
            }
        }
        public bool YES { get; set; }

        //public ProductDB ProductData { get; set; }
        //private ProductRepository productRepository = new ProductRepository();

        public ConfirmationDialog()
        {
            InitializeComponent();
        }

        private void btyes_Click(object sender, EventArgs e)
        {
            //int itemid = ProductData.id;
            //if (productRepository.Delete(itemid))
            //    Close();
            //else
            //    MessageBox.Show("Gagal menghapus brand");

            YES = true;
            Close();
        }

        private void btno_Click(object sender, EventArgs e)
        {
            YES = false;
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btnYes.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                btnNo.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



    }
}

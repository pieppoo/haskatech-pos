using POSsystem.Database;
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
    public partial class MainForm : Form
    {
        public LoginDetails userdata { get; set; }
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            var form = new ManageProduct();
            form.userdata = userdata;
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.userdata = userdata;
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btreport_Click(object sender, EventArgs e)
        {
            var form = new Report();
            form.userdata = userdata;
            Hide();
            form.ShowDialog();
            Show();
        }

        private void changepswd_Click(object sender, EventArgs e)
        {
            var form = new ManagePassword();
            form.userdata = userdata;
            Hide();
            form.ShowDialog();
            Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (userdata.user_role == "kasir")
            {
                this.Size = new Size(500, 200);
                btnproduct.Visible = false;
                btreport.Visible = false;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btnhistory.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                changepswd.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btreport.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                btnproduct.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Apa Anda Yakin keluar dari sistem ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

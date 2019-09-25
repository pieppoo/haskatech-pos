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

namespace POSsystem.Views
{
    public partial class ManagePassword : BaseForm
    {
        public LoginDetails userdata { get; set; }
        private LoginRepository loginRepository = new LoginRepository();
        public ManagePassword()
        {
            InitializeComponent();
        }

        private void ManagePassword_Load(object sender, EventArgs e)
        {
            lbname.Text = "Pengguna: " + userdata.name;
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (tbnewpswd.Text == "" || tbnewpswdconfirm.Text == "")
                MessageBox.Show("Silahkan isi kedua box dengan kata sandi yang sama");
            else if (tbnewpswd.Text != tbnewpswdconfirm.Text)
                MessageBox.Show("Kedua kata sandi tidak sama");
            else
            {
                var logininfo = new LoginDetails();
                logininfo.id = userdata.id;
                logininfo.password = tbnewpswdconfirm.Text;

                if(loginRepository.updatepswd(logininfo))
                {
                    MessageBox.Show("Kata sandi anda telah berhasil diganti");
                    Close();
                }
                else
                    MessageBox.Show("error, Kata sandi tidak bisa diganti");

            }
        }

        private void tbnewpswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbnewpswdconfirm.Focus();
        }

        private void tbnewpswdconfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnchange.PerformClick();
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

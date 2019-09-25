using POSsystem.Database;
using POSsystem.Repository;
using POSsystem.Views;
using POSsystem.Views.Settings;
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
    public partial class LoginForm : Form
    {
        private LoginRepository loginRepository = new LoginRepository(); 
        public List<LoginDetails> LoginList { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btmasuk_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != "")
            {
                if (tbpassword.Text != "")
                {

                    LoginList = loginRepository.GetAll(tbusername.Text);

                    if (LoginList != null)
                    {
                        if (LoginList.Count > 0)
                        {
                            foreach (var item in LoginList)
                            {
                                if (item.status_code == "A")
                                {
                                    if (item.password == tbpassword.Text)
                                    {
                                        var login_info = new LoginDetails();
                                        login_info.id = item.id;
                                        login_info.password = tbpassword.Text;
                                        login_info.username = tbusername.Text;
                                        login_info.lastlogin = DateTime.Now.ToString();
                                        login_info.user_role = item.user_role;
                                        login_info.name = item.name;

                                        if (loginRepository.Updatelastlogin(login_info))
                                        {
                                                var form = new MainForm();
                                                form.userdata = login_info;
                                                Hide();
                                                form.ShowDialog();
                                                Close();
                                        }
                                        else
                                            MessageBox.Show("Ada error pada saat mengupdate last login");

                                    }
                                    else
                                        MessageBox.Show("Anda memasukkan kata sandi yang salah");
                                }
                                else
                                    MessageBox.Show("Pengguna ini sudah tidak aktif");
                            }
                        }
                        else
                            MessageBox.Show("Nama anda belum terdaftar");
                    }
                    else
                        MessageBox.Show("koneksi ke database mati");
                }
                else
                    MessageBox.Show("Anda belum memasukkan kata sandi");
            }
            else
                MessageBox.Show("Anda belum memasukkan nama");



        }

        private void llblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new AuthenticationForm();
            form.ShowDialog(this);
        }

        private void LoginEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btmasuk.PerformClick();
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            loginRepository  = new LoginRepository();
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

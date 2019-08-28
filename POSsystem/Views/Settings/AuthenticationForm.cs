using System;
using System.Windows.Forms;

namespace POSsystem.Views.Settings
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals("admin123!"))
            {
                Close();
                var form = new SettingsForm();
                form.ShowDialog(Parent);
            }
            else
            {
                MessageBox.Show("Sandi Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmit.PerformClick();
        }
    }
}

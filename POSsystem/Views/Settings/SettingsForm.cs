using System;
using System.Windows.Forms;

namespace POSsystem.Views.Settings
{
    public partial class SettingsForm : Form
    {
        public string DefaultConnString
        {
            get
            {
                return "Server=localhost;Database=possystem;Uid=root;Pwd=admin123;";
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.connection_string))
            {
                tbConnectionString.Text = DefaultConnString;
            }
            else
            {
                tbConnectionString.Text = Properties.Settings.Default.connection_string;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.connection_string = tbConnectionString.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Setting telah disimpan", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
        }

    }
}

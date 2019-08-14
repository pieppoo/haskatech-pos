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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btmasuk_Click(object sender, EventArgs e)
        {
            var form = new ManageProduct();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}

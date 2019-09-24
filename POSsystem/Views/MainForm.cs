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
    }
}

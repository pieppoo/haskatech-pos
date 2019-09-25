using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace POSsystem.Views
{
    public partial class LoadingDialog : Form
    {
        private Timer timer = new Timer();
        private bool allowClose;

        public int TimeoutSec { get; set; }

        public string Message
        {
            get
            {
                return lblMessage.Text;
            }
            set
            {
                lblMessage.Text = value;
            }
        }

        public LoadingDialog()
        {
            InitializeComponent();

            allowClose = false;
            TimeoutSec = 5;

            timer.Interval = TimeoutSec * 1000;
            timer.Tick += Timer_Tick;
        }

        public void EnableClosingForm()
        {
            allowClose = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            allowClose = true;
            timer.Stop();
        }

        private void LoadingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;
            }
        }

        private void LoadingDialog_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}

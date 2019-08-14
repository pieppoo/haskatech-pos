using System.Windows.Forms;

namespace POSsystem.Views.Base
{
    public partial class BaseForm : Form
    {
        public string Title {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value ;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }
    }
}

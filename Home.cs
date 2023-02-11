using System;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public static DataInput dataForm = new DataInput();
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            dataForm = new DataInput();
            dataForm.Show();
            this.Hide();
        }
    }
}

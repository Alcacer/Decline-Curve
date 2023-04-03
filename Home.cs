using System;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    public partial class Home : Form
    {
        internal static DataInput dataForm = new DataInput();
        public Home()
        {
            InitializeComponent();
        }
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            dataForm = new DataInput();
            dataForm.Show();
            Hide();
        }
    }
}
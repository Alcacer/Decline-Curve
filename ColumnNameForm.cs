using System;
using System.Windows.Forms;
using static Decline_Curve_Analysis.DataInput;

namespace Decline_Curve_Analysis
{
    public partial class ColumnNameForm : Form
    {
        public ColumnNameForm()
        {
            InitializeComponent();
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(DaysTextBox.Text.Trim() != "" && ProductionTextbox.Text.Trim() != "")
            {
                requiredColumns[0] = DaysTextBox.Text.ToLower();
                requiredColumns[1] = ProductionTextbox.Text.ToLower();
                Close();
            }
        }
    }
}

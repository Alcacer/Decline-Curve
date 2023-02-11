using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void BacktoAnalysisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Decline_Curve_Analysis.Graph;

namespace Decline_Curve_Analysis
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }
        private void Results_Load(object sender, EventArgs e)
        {
            resultsDataGridView.DataSource = resultsTable;
        }
        private void BacktoAnalysisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

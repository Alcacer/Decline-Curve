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
            foreach (DataGridViewColumn column in resultsDataGridView.Columns) //removed the selection of the cells in the datagridview
            {                                                                  //which was causing some visual issues in the numbers when
                column.SortMode = DataGridViewColumnSortMode.NotSortable;      //the datagrid is scrolled up and down.
            }
        }
        private void BacktoAnalysisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

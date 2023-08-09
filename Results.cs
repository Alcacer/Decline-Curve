using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;


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
            resultsDataGridView.DataSource = Graph.resultsTable;
            foreach (DataGridViewColumn column in resultsDataGridView.Columns) //Removed the selection of the cells in the datagridview
            {                                                                  //which was causing some visual issues in the numbers when
                column.SortMode = DataGridViewColumnSortMode.NotSortable;      //the datagrid is scrolled up and down.
            }
        }
        private void BacktoAnalysisButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveTableButton_Click(object sender, EventArgs e)
        {
            //Saving the resulting datatable to the system storage.
            StringBuilder output = new StringBuilder();
            List<string> commaInRows = new List<string> { };
            output.Append($"{Graph.resultsTable.Columns[0]},");
            output.Append(Graph.resultsTable.Columns[1].ToString());
            foreach (DataRow row in Graph.resultsTable.Rows)
            {
                output.AppendLine();
                foreach (DataColumn column in Graph.resultsTable.Columns)
                {
                    commaInRows.Add(row[column].ToString());
                }
                output.Append(string.Join(",", commaInRows));
                commaInRows.Clear();
            }
            SaveFileDialog saveResultsDialog = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv" };
            if (saveResultsDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveResultsDialog.FileName, output.ToString());
                SaveTableButton.Enabled = false;
            }
        }
    }
}
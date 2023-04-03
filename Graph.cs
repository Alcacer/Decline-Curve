using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Decline_Curve_Analysis
{
    public partial class Graph : Form
    {
        internal static DataTable resultsTable = new DataTable();
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            ChartArea declineChartArea = new ChartArea { Name = "Decline Chart Area" };
            GraphCalculations.GraphAxisSetter(DeclineGraph, declineChartArea, DataInput.dataTable);
            TabulizeResultsButton.Enabled = false;
            DeclineGraph.DataSource = DataInput.dataTable;
            DeclineGraph.DataBind();
        }
         
        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            resultsTable = GraphCalculations.CalculateDecline(DeclineGraph, DataInput.dataTable, 10);
            TabulizeResultsButton.Enabled = true;
            RunPredictionButton.Enabled = false;
            WindowState = FormWindowState.Maximized;
        }

        private string closeReason;
        private void BackButton_Click(object sender, EventArgs e)
        {
            closeReason = "backbutton";
            Close();
        }
        private void Graph_Closed(object sender, FormClosedEventArgs e)
        {
            //Make the whole application close if the X button or Alt + F4 is pressed, but not when the back button is pressed.
            if (closeReason == "backbutton")
            {
                Home.dataForm.Show();
            }
            else
            {
                Home.dataForm.Close();
            }
        }
        private void TabulizeResultsButton_Click(object sender, EventArgs e)
        {
            Results resultForm = new Results();
            resultForm.ShowDialog();
        }
    }
}
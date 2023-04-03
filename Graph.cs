using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Decline_Curve_Analysis.Home;
using static Decline_Curve_Analysis.DataInput;


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
            GraphCalculations.GraphAxisSetter(DeclineGraph, declineChartArea, dataTable);
            TabulizeResultsButton.Enabled = false;
            DeclineGraph.DataSource = dataTable;
            DeclineGraph.DataBind();
        }
         
        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            resultsTable = GraphCalculations.CalculateDecline(DeclineGraph, dataTable, 10);
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
                dataForm.Show();
            }
            else
            {
                dataForm.Close();
            }
        }
        private void TabulizeResultsButton_Click(object sender, EventArgs e)
        {
            Results resultForm = new Results();
            resultForm.ShowDialog();
        }
    }
}
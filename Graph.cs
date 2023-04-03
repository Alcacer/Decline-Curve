using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Decline_Curve_Analysis.Home;
using static Decline_Curve_Analysis.DataInput;
using static Decline_Curve_Analysis.GraphCalculations;


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
            declineChartArea.AxisX.Interval = 1D;
            declineChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;

            //Make the interval of the y-axis to auto adjust to the maximum value of the production data.
            double maxValue = dataTable.AsEnumerable().Select(x => Convert.ToDouble(x[dataTable.Columns[1]])).ToArray().Max();
            if (maxValue > 800)
            {
                declineChartArea.AxisY.Interval = 75D;
            }

            else if (maxValue < 100)
            {
                declineChartArea.AxisY.Interval = 5D;
            }

            else
            {
                declineChartArea.AxisY.Interval = 25D;
            }

            declineChartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            DeclineGraph.ChartAreas.Add(declineChartArea);
            DeclineGraph.Series[0].ChartArea = "Decline Chart Area";
            DeclineGraph.Series[1].ChartArea = "Decline Chart Area";

            TabulizeResultsButton.Enabled = false;
            DeclineGraph.ChartAreas[0].AxisX.Title = dataTable.Columns[0].ToString();
            DeclineGraph.ChartAreas[0].AxisY.Title = dataTable.Columns[1].ToString();

            //For the data points
            DeclineGraph.Series[0].XValueMember = dataTable.Columns[0].ToString();
            DeclineGraph.Series[0].YValueMembers = dataTable.Columns[1].ToString();

            //For the line through the data points
            DeclineGraph.Series[1].XValueMember = dataTable.Columns[0].ToString();
            DeclineGraph.Series[1].YValueMembers = dataTable.Columns[1].ToString();

            DeclineGraph.DataSource = dataTable;
            DeclineGraph.DataBind();
        }
         
        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            resultsTable = CalculateDecline(dataTable, 10, DeclineGraph);
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
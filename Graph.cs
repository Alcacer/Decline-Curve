using MathNet.Numerics;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static Decline_Curve_Analysis.Home;
using static Decline_Curve_Analysis.DataInput;

namespace Decline_Curve_Analysis
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        internal static DataTable resultsTable = new DataTable();
        private void Graph_Load(object sender, EventArgs e)
        {
            TabulizeResultsButton.Enabled = false;
            DeclineGraph.ChartAreas[0].AxisX.Title = dataTable.Columns[0].ToString();
            DeclineGraph.ChartAreas[0].AxisY.Title = dataTable.Columns[1].ToString();
            DeclineGraph.Series[0].XValueMember = dataTable.Columns[0].ToString();
            DeclineGraph.Series[0].YValueMembers = dataTable.Columns[1].ToString();
            DeclineGraph.DataSource = dataTable;
            DeclineGraph.DataBind();
        }
         
        private void CalculateExponentialDecline(DataTable productionData, int forecastDays, double timeIncrement)
        {
            // Extract the production and time data from the input DataTable
            var production = productionData.AsEnumerable().Select(r => Convert.ToDouble(r["Flow Rate"])).ToArray();
            var time = productionData.AsEnumerable().Select(r => DateTime.ParseExact(r["Time"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToArray();

            // Fit an exponential decline function to the production data using linear regression
            double[] xData = time.Select(r => (double)r.Day).ToArray();
            double[] yData = production.Select(r => Math.Log(r)).ToArray();
            var regressionResult = Fit.Line(xData, yData);
            var Q0 = Math.Exp(regressionResult.A);
            double D = -regressionResult.B;

            // Calculate the predicted production values for the future time period
            DateTime lastTime = time[time.Length - 1];
            DateTime[] futureTime = Enumerable.Range(1, forecastDays)
                                       .Select(i => lastTime.AddDays(i * timeIncrement)) // this way if enough days are added, it goes on to the next month.
                                       .ToArray();
            
            double[] futureProduction = futureTime.Select(t => production[production.Length-1] * Math.Exp(-D * (t - lastTime).Days)).ToArray(); //since both t and lasttime are datetime objects,
                                                                                                              //its more accurate to subtract them from each other
                                                                                                              //before getting the days from the resulting timespan. 

            // Print the results
            MessageBox.Show($"Initial production rate (Q0): {Q0}\n\nDecline rate (D): {D}", "Results");
            DataRow[] dataRows = new DataRow[forecastDays];
            for (int i = 0; i < forecastDays; i++)
            {
                DataRow row = productionData.NewRow();
                DeclineGraph.Series["DeclineSeries"].Points.AddXY(futureTime[i].ToShortDateString(), futureProduction[i]);
                DeclineGraph.Series["DeclineSeries"].Points[productionData.Rows.Count + i].Color = Color.Red;
                row[0] = futureTime[i].ToShortDateString();
                row[1] = Math.Round(futureProduction[i], 2, MidpointRounding.AwayFromZero); //rounds the calculated future production data
                dataRows[i] = row;                                                          //to 2 decimal places at most.
            }

            foreach (DataRow row in dataRows)
            {
                productionData.Rows.Add(row);
            }
            resultsTable = productionData;
        }


        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            CalculateExponentialDecline(dataTable, 10, 1);
            TabulizeResultsButton.Enabled = true;
            RunPredictionButton.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            closeReason = "backbutton";
            this.Close();
        }
        private string closeReason;
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

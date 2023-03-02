using MathNet.Numerics;
using MathNet.Numerics.LinearRegression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Decline_Curve_Analysis.Home;
using static Decline_Curve_Analysis.DataInput;
using MathNet.Numerics.Distributions;
using System.Windows.Forms.DataVisualization.Charting;

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
            var Q0 = Math.Exp(regressionResult.Item1);
            double D = -regressionResult.Item2;

            // Calculate the predicted production values for the future time period
            DateTime lastTime = time[time.Length - 1];
            DateTime[] futureTime = Enumerable.Range(1, forecastDays)
                                       .Select(i => lastTime.AddDays(i * timeIncrement)) // this way if enough days are added, it goes on to the next month.
                                       .ToArray();
            
            double[] futureProduction = futureTime.Select(t => production[production.Length-1] * Math.Exp(-D * (t - lastTime).Days)).ToArray(); //since both t and lasttime are datetime objects,
                                                                                                              //its more accurate to subtract them from each other
                                                                                                              //before getting the days from the resulting timespan. 

            // Print the results
            MessageBox.Show($"Initial production rate (Q0): {Q0}\nDecline rate (D): {D}");
            DataRow[] dataRows = new DataRow[forecastDays];
            for (int i = 0; i < forecastDays; i++)
            {
                DataRow row = productionData.NewRow();
                DeclineGraph.Series["DeclineSeries"].Points.AddXY(futureTime[i].ToShortDateString(), futureProduction[i]);
                DeclineGraph.Series["DeclineSeries"].Points[productionData.Rows.Count + i].Color = Color.Red;
                row[0] = futureTime[i].ToShortDateString();
                row[1] = futureProduction[i];
                dataRows[i] = row;
            }
            foreach (DataRow row in dataRows)
            {
                productionData.Rows.Add(row);
                string thisa = "this is a string";
            }
            resultsTable = productionData;
        }


        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            CalculateExponentialDecline(dataTable, 10, 1);
            TabulizeResultsButton.Enabled = true;
            RunPredictionButton.Enabled = false;
            //TODO - When this button is clicked the window should be maximized and therefore fit the screen of the system, whatever the
            //size of the system is. Then the buttons and the graph should be docked to prevent it from being scattered when maximized.
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Graph_Close(object sender, FormClosedEventArgs e)
        {
            dataForm.Show();
            // TODO - Try and see if the X button alone can be targeted, so that if the X button is pressed
            //It closes the whole application; but if the back button is pressed, which actually closes the
            //form and triggers this function too, it still goes back to the data input form.
        }

        private void TabulizeResultsButton_Click(object sender, EventArgs e)
        {
            Results resultForm = new Results();
            resultForm.ShowDialog();
        }
    }
}

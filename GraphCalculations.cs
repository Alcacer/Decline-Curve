using System;
using System.Data;
using System.Drawing;
using System.Linq;
using MathNet.Numerics;


namespace Decline_Curve_Analysis
{
    internal class GraphCalculations
    {
        internal static DataTable CalculateDecline(DataTable productionData, int forecastDays, 
            System.Windows.Forms.DataVisualization.Charting.Chart declineGraph)
        {
            // Extract the production and time data from the input DataTable
            double[] production = productionData.AsEnumerable().Select(r => Convert.ToDouble(r[productionData.Columns[1]])).ToArray();
            double[] time = productionData.AsEnumerable().Select(r => Convert.ToDouble(r[productionData.Columns[0]])).ToArray();

            // Fit an exponential decline function to the production data using linear regression
            double[] yData = production.Select(r => Math.Log(r)).ToArray();
            var regressionResult = Fit.Line(time, yData);
            double Q0 = Math.Exp(regressionResult.A);
            double D = -regressionResult.B;

            // Calculate the predicted production values for the future time period
            double lastTime = time[time.Length - 1];
            double timeIncrement = lastTime - time[time.Length - 2]; //makes the timeincrement to follow the same order as the data in the table.
            double[] futureTime = Enumerable.Range(1, forecastDays).Select(i => lastTime + (i * timeIncrement)).ToArray();

            double[] futureProduction = futureTime.Select(t => production[production.Length - 1] * Math.Exp(-D * (t - lastTime))).ToArray();

            // Show the results
            System.Windows.Forms.MessageBox.Show($"Initial production rate (Q0): {Q0}\n\nDecline rate (D): {D}", "Results");

            //This adds the future production data to the graph
            DataRow[] dataRows = new DataRow[forecastDays];
            for (int i = 0; i < forecastDays; i++)
            {
                DataRow row = productionData.NewRow();
                declineGraph.Series["DeclineSeries"].Points.AddXY(futureTime[i].ToString(), futureProduction[i]);
                declineGraph.Series["DeclineSeries"].Points[productionData.Rows.Count + i].Color = Color.Red;
                declineGraph.Series["Line"].Points.AddXY(futureTime[i].ToString(), futureProduction[i]);
                row[0] = futureTime[i];
                row[1] = Math.Round(futureProduction[i], 2, MidpointRounding.AwayFromZero); //rounds the calculated future production data
                dataRows[i] = row;                                                          //to 2 decimal places at most.
            }
            //Add the predicted values to the datatable to display it in the results form
            foreach (DataRow row in dataRows)
            {
                productionData.Rows.Add(row);
            }
            return productionData;
        }
    }
}

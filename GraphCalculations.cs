using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;


namespace Decline_Curve_Analysis
{
    internal class GraphCalculations
    {
        internal static DataTable CalculateDecline(Chart declineGraph, DataTable productionData, int forecastDays)
        {
            // Extract the production and time data from the input DataTable
            double[] production = productionData.AsEnumerable().
                Select(r => Convert.ToDouble(r[productionData.Columns[1]])).ToArray();
            double[] time = productionData.AsEnumerable().
                Select(r => Convert.ToDouble(r[productionData.Columns[0]])).ToArray();

            // Fit an exponential decline function to the production data using linear regression
            double[] yData = production.Select(r => Math.Log(r)).ToArray();
            var regressionResult = Fit.Line(time, yData);
            double Q0 = Math.Exp(regressionResult.A);
            double D = -regressionResult.B;

            //Calculating predicted future values.
            double lastTime = time[time.Length - 1];

            double timeIncrement = lastTime - time[time.Length - 2];
            //Makes the timeincrement to follow the same order as the data in the table.


            double[] futureTime = Enumerable.Range(1, forecastDays).Select(i => lastTime + (i * timeIncrement)).ToArray();

            double[] futureProduction = futureTime.Select(t => production[production.Length - 1] * 
                                                          Math.Exp(-D * (t - lastTime))).ToArray();


            System.Windows.Forms.MessageBox.Show($"Initial production rate (Q0): {Q0}\n\nDecline rate (D): {D}", "Results");

            DataRow[] dataRows = new DataRow[forecastDays]; //This adds the future production data to the graph

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



                //Dynamically set the intervals on the Y-axis depending on the data in the datatable.
        internal static void GraphAxisSetter(Chart declineGraph, ChartArea declineChartArea, DataTable sourceData)
        {
            declineChartArea.AxisX.Interval = 1D;
            declineChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;

            //Make the interval of the y-axis to auto adjust to the maximum value of the production data.
            double maxValue = sourceData.AsEnumerable().Select(x => Convert.ToDouble(x[sourceData.Columns[1]])).ToArray().Max();
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
            declineGraph.ChartAreas.Add(declineChartArea);
            declineGraph.Series[0].ChartArea = "Decline Chart Area";
            declineGraph.Series[1].ChartArea = "Decline Chart Area";

            declineGraph.ChartAreas[0].AxisX.Title = sourceData.Columns[0].ToString();
            declineGraph.ChartAreas[0].AxisY.Title = sourceData.Columns[1].ToString();

            //For the data points
            declineGraph.Series[0].XValueMember = sourceData.Columns[0].ToString();
            declineGraph.Series[0].YValueMembers = sourceData.Columns[1].ToString();

            //For the line through the data points
            declineGraph.Series[1].XValueMember = sourceData.Columns[0].ToString();
            declineGraph.Series[1].YValueMembers = sourceData.Columns[1].ToString();
        }
    }
}

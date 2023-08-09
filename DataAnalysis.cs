using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    internal class DataAnalysis
    {
        internal static List<string> requiredColumns = new List<string> { "days", "production rate" };
        private static int firstHeaderNumber, secondHeaderNumber;

        internal static DataTable GetDataTable(string filePath)
        {

            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the header line
                string check = sr.ReadLine();

                //Check to see if the ReadLine returned null, that is if it's empty, this will also be useful since you cant
                //use the Split method on a Null variable, it'll just give you some type of Null error.
                if (check == null)
                {
                    MessageBox.Show("No Data Found.", "Empty File");
                    return null;
                }

                else
                {
                    string[] headers = check.Split(',');
                    List<string> lowercaseHeaders = headers.Select(x => x.ToLower()).ToList();

                    //Checking if the headers in the selected file are in the requiredColumns array.
                    if (!(lowercaseHeaders.Contains(requiredColumns[0]) &&
                        lowercaseHeaders.Contains(requiredColumns[1])))
                    {
                        MessageBox.Show("The required columns could not be found.\n" +
                            $"Please make sure you have both the {requiredColumns[0]} and {requiredColumns[1]} columns in your file.",
                            "Missing Columns");
                        return null;
                    }

                    else
                    {
                        // Add the headers to the DataTable
                        firstHeaderNumber = lowercaseHeaders.IndexOf(requiredColumns[0]);
                        secondHeaderNumber = lowercaseHeaders.IndexOf(requiredColumns[1]);
                        dataTable.Columns.Add(headers[firstHeaderNumber]);
                        dataTable.Columns.Add(headers[secondHeaderNumber]);

                        // Read the rest of the data
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dataRow = dataTable.NewRow();

                            //Check to see if the values in the csv file are actually numbers
                            if (double.TryParse(rows[firstHeaderNumber], out double firstResultRow))
                            {
                                dataRow[0] = firstResultRow;
                            }

                            else
                            {
                                MessageBox.Show($"Some of the data in the {dataTable.Columns[0]} column are not numbers.", "Unsupported Format");
                                return null;
                            }

                            if (double.TryParse(rows[secondHeaderNumber], out double secondResultRow))
                            {
                                dataRow[1] = secondResultRow;
                            }

                            else
                            {
                                MessageBox.Show($"Some of the data in the {dataTable.Columns[1]} column are not numbers.", "Unsupported Format");
                                return null;
                            }

                            dataTable.Rows.Add(dataRow);
                        }
                    }
                }
            }
            return dataTable;
        }
    }
}
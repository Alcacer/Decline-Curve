using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    public partial class DataInput : Form
    {
        public DataInput()
        {
            InitializeComponent();
        }
        internal static DataTable dataTable = new DataTable();
        private static string[] requiredColumns = { "time", "flow rate" };
        private static int firstHeaderNumber, secondHeaderNumber;
        private DataTable GetDataTable(string filePath)
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
                    MessageBox.Show("No Data Found", "Empty File");
                    DataListBox.Items.Clear();
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
                        MessageBox.Show("The Required Columns are Missing.\n" +
                            "Please make sure you have both Time and Flow Rate columns in your file.", "Missing Columns");
                        DataListBox.Items.Clear();
                        return null;
                    }
                    else
                    {
                        // Add the headers to the DataTable
                        firstHeaderNumber = lowercaseHeaders.IndexOf("time");
                        secondHeaderNumber = lowercaseHeaders.IndexOf("flow rate");
                        dataTable.Columns.Add(lowercaseHeaders[firstHeaderNumber]);
                        dataTable.Columns.Add(lowercaseHeaders[secondHeaderNumber]);
                        // Read the rest of the data
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dataRow = dataTable.NewRow();
                            dataRow[0] = rows[firstHeaderNumber]; 
                           //Check to see if the values in the csv file are actually numbers
                            if (Double.TryParse(rows[secondHeaderNumber], out double resultRow))
                            {
                                dataRow[1] = resultRow;
                            }
                            else
                            {
                                MessageBox.Show("Some of the data in your file are not numbers.", "Unsupported Format");
                                return null;
                            } 
                            dataTable.Rows.Add(dataRow);
                        }
                    }
                }
            }
            return dataTable;
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "CSV Files (*.csv)|*.csv" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataListBox.Items.Clear();
                DataListBox.Items.Add(openFileDialog.FileName);
            }
        }

        private void AnalyseDataButton_Click(object sender, EventArgs e)
        {
            if (DataListBox.Items.Count == 0)
            {
                MessageBox.Show("Please Enter a File into the Box", "No File Found");
            }
            //TODO - Check the contents of the rows in the datatable, especially the production data, to see if there are any blanks or non-numbers mixed in.
            else
            {
                dataTable = GetDataTable(DataListBox.Items[0].ToString());
                if (dataTable != null)
                {
                    Graph graphForm = new Graph();
                    graphForm.Show();
                    this.Hide();
                } 
            }
        }
        private void DataListBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop); //casts the object as an array to make it easier to work with.

            //Check to see if its just one file being dragged, and if it is indeed a file and not a folder,
            //and to check the extension of the file.
            if (files != null && files.Length==1 && File.Exists(files[0]) && Path.
                GetExtension(files[0]).ToLower() == ".csv")
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void DataListBox_DragDrop(object sender, DragEventArgs e)
        {
            DataListBox.Items.Clear();
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            DataListBox.Items.Add(files.First());
        }
        //Closes all open forms including the hidden home form as there is no need to go back to that form.
        private void DataInput_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

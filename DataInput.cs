using System;
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
        private static int count = 0;
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
                    string[] lowercaseHeaders = headers.Select(x => x.ToLower()).ToArray();


                    //Checking if the headers in the selected file are in the requiredColumns array.
                    if (!(lowercaseHeaders.Contains(requiredColumns[0]) &&
                        lowercaseHeaders.Contains(requiredColumns[1])))
                    {
                        MessageBox.Show("The Required Columns are Missing.", "Missing Columns");
                        DataListBox.Items.Clear();
                        return null;
                    }
                    else
                    {
                        // Add the headers to the DataTable
                        foreach (string header in headers)
                        {
                            //Only going to add the required headers to the datatable.
                            if (Equals(header.ToLower(), requiredColumns[0].ToLower()))
                            {
                                dataTable.Columns.Add(header);
                                firstHeaderNumber = count;
                            }
                            else if (Equals(header.ToLower(), requiredColumns[1].ToLower()))
                            {
                                dataTable.Columns.Add(header);
                                secondHeaderNumber = count;
                            }
                            count++;
                            if (dataTable.Columns.Count == 2)
                            {
                                count = 0;
                                break;
                            }
                        }
                        // Read the rest of the data
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dataRow = dataTable.NewRow();
                            for (int i = 0; i < headers.Length; i++)
                            {
                                //Only going to add the fields of the required headers to the row
                                if (i == firstHeaderNumber)
                                {
                                    dataRow[0] = rows[firstHeaderNumber];
                                }
                                else if (i == secondHeaderNumber)
                                {
                                    dataRow[1] = rows[secondHeaderNumber];
                                    break;
                                }
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
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
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop); //casts the object as an array to make it easier to work with

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
        //Closes all open forms including the hidden home form as there is no need to go back to that form
        private void DataInput_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

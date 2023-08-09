using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Decline_Curve_Analysis
{
    public partial class DataInput : Form
    {
        //Initializing the datatable.
        internal static DataTable dataTable;
        
        public DataInput()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
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

            else
            {
                //The GetDataTable function is from the DataAnalysis class, which is used to analyse the data and return a datatable.
                dataTable = DataAnalysis.GetDataTable(DataListBox.Items[0].ToString()); 
               
                if (dataTable != null)
                {
                    Graph graphForm = new Graph();
                    graphForm.Show();
                    Hide();
                } 
            }
        }

        private void DataListBox_DragEnter(object sender, DragEventArgs e)
        {
            //Casts the object as an array to make it easier to work with.
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);

            //Check to see if its just one file being dragged; and if it is indeed a file and not a folder; 
            //and to check the extension of the file.
            if (files != null && files.Length == 1 && File.Exists(files[0]) &&
                Path.GetExtension(files[0]).ToLower() == ".csv")
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


        private void DifferentColumnsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColumnNameForm columnNameForm = new ColumnNameForm();
            columnNameForm.ShowDialog();
        }

        //Closes all open forms including the hidden home form as there is no need to go back to that form.
        private void DataInput_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
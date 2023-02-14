using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Graph_Load(object sender, EventArgs e)
        {
            TabulizeResultsButton.Enabled = false;
            DeclineGraph.DataSource = dataTable;
            DeclineGraph.DataBind();
        }

        private void RunPredictionButton_Click(object sender, EventArgs e)
        {
            TabulizeResultsButton.Enabled = true;
            RunPredictionButton.Enabled = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            dataForm.Show();
            
        }
        private void Graph_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TabulizeResultsButton_Click(object sender, EventArgs e)
        {
            Results resultForm = new Results();
            resultForm.ShowDialog();
        }
    }
}

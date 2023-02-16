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

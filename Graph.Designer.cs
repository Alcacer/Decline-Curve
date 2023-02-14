namespace Decline_Curve_Analysis
{
    partial class Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RunPredictionButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TabulizeResultsButton = new System.Windows.Forms.Button();
            this.DeclineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DeclineGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // RunPredictionButton
            // 
            this.RunPredictionButton.BackColor = System.Drawing.Color.Azure;
            this.RunPredictionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunPredictionButton.Location = new System.Drawing.Point(1116, 354);
            this.RunPredictionButton.Name = "RunPredictionButton";
            this.RunPredictionButton.Size = new System.Drawing.Size(127, 43);
            this.RunPredictionButton.TabIndex = 4;
            this.RunPredictionButton.Text = "Run Prediction";
            this.RunPredictionButton.UseVisualStyleBackColor = false;
            this.RunPredictionButton.Click += new System.EventHandler(this.RunPredictionButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Azure;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1116, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 41);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TabulizeResultsButton
            // 
            this.TabulizeResultsButton.BackColor = System.Drawing.Color.Azure;
            this.TabulizeResultsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabulizeResultsButton.Location = new System.Drawing.Point(1116, 414);
            this.TabulizeResultsButton.Name = "TabulizeResultsButton";
            this.TabulizeResultsButton.Size = new System.Drawing.Size(127, 42);
            this.TabulizeResultsButton.TabIndex = 6;
            this.TabulizeResultsButton.Text = "Tabulize Results";
            this.TabulizeResultsButton.UseVisualStyleBackColor = false;
            this.TabulizeResultsButton.Click += new System.EventHandler(this.TabulizeResultsButton_Click);
            // 
            // DeclineGraph
            // 
            this.DeclineGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 0.5D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "Flow Rate";
            chartArea1.Name = "ChartArea1";
            this.DeclineGraph.ChartAreas.Add(chartArea1);
            this.DeclineGraph.Location = new System.Drawing.Point(3, 12);
            this.DeclineGraph.Name = "DeclineGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "DeclineSeries";
            series1.XValueMember = "time";
            series1.YValueMembers = "flow rate";
            this.DeclineGraph.Series.Add(series1);
            this.DeclineGraph.Size = new System.Drawing.Size(1107, 643);
            this.DeclineGraph.TabIndex = 0;
            this.DeclineGraph.Text = "chart1";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TabulizeResultsButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RunPredictionButton);
            this.Controls.Add(this.DeclineGraph);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Graph_Close);
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeclineGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RunPredictionButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button TabulizeResultsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart DeclineGraph;
    }
}
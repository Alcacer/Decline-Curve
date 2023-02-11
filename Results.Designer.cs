namespace Decline_Curve_Analysis
{
    partial class Results
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
            this.components = new System.ComponentModel.Container();
            this.BacktoAnalysisButton = new System.Windows.Forms.Button();
            this.SaveTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BacktoAnalysisButton
            // 
            this.BacktoAnalysisButton.BackColor = System.Drawing.Color.Azure;
            this.BacktoAnalysisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoAnalysisButton.ForeColor = System.Drawing.Color.Black;
            this.BacktoAnalysisButton.Location = new System.Drawing.Point(406, 176);
            this.BacktoAnalysisButton.Name = "BacktoAnalysisButton";
            this.BacktoAnalysisButton.Size = new System.Drawing.Size(138, 40);
            this.BacktoAnalysisButton.TabIndex = 1;
            this.BacktoAnalysisButton.Text = "Back to Analysis";
            this.BacktoAnalysisButton.UseVisualStyleBackColor = false;
            this.BacktoAnalysisButton.Click += new System.EventHandler(this.BacktoAnalysisButton_Click);
            // 
            // SaveTableButton
            // 
            this.SaveTableButton.BackColor = System.Drawing.Color.Azure;
            this.SaveTableButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTableButton.ForeColor = System.Drawing.Color.Black;
            this.SaveTableButton.Location = new System.Drawing.Point(406, 241);
            this.SaveTableButton.Name = "SaveTableButton";
            this.SaveTableButton.Size = new System.Drawing.Size(138, 40);
            this.SaveTableButton.TabIndex = 3;
            this.SaveTableButton.Text = "Save Table";
            this.SaveTableButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.flowRateDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(358, 375);
            this.dataGridView1.TabIndex = 4;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowRateDataGridViewTextBoxColumn
            // 
            this.flowRateDataGridViewTextBoxColumn.DataPropertyName = "FlowRate";
            this.flowRateDataGridViewTextBoxColumn.HeaderText = "FlowRate";
            this.flowRateDataGridViewTextBoxColumn.Name = "flowRateDataGridViewTextBoxColumn";
            this.flowRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveTableButton);
            this.Controls.Add(this.BacktoAnalysisButton);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BacktoAnalysisButton;
        private System.Windows.Forms.Button SaveTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowRateDataGridViewTextBoxColumn;
    }
}
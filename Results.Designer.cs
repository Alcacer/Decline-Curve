﻿namespace Decline_Curve_Analysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BacktoAnalysisButton = new System.Windows.Forms.Button();
            this.SaveTableButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BacktoAnalysisButton
            // 
            this.BacktoAnalysisButton.BackColor = System.Drawing.Color.Azure;
            this.BacktoAnalysisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoAnalysisButton.ForeColor = System.Drawing.Color.Black;
            this.BacktoAnalysisButton.Location = new System.Drawing.Point(406, 176);
            this.BacktoAnalysisButton.Name = "BacktoAnalysisButton";
            this.BacktoAnalysisButton.Size = new System.Drawing.Size(137, 40);
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
            this.SaveTableButton.Size = new System.Drawing.Size(137, 40);
            this.SaveTableButton.TabIndex = 3;
            this.SaveTableButton.Text = "Save Table";
            this.SaveTableButton.UseVisualStyleBackColor = false;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.AllowUserToResizeColumns = false;
            this.resultsDataGridView.AllowUserToResizeRows = false;
            this.resultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.resultsDataGridView.CausesValidation = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.GridColor = System.Drawing.Color.LightGray;
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.resultsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.NullValue = null;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            this.resultsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.resultsDataGridView.RowTemplate.ReadOnly = true;
            this.resultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.resultsDataGridView.ShowCellErrors = false;
            this.resultsDataGridView.ShowCellToolTips = false;
            this.resultsDataGridView.ShowEditingIcon = false;
            this.resultsDataGridView.ShowRowErrors = false;
            this.resultsDataGridView.Size = new System.Drawing.Size(358, 375);
            this.resultsDataGridView.TabIndex = 4;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.SaveTableButton);
            this.Controls.Add(this.BacktoAnalysisButton);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Results";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BacktoAnalysisButton;
        private System.Windows.Forms.Button SaveTableButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}
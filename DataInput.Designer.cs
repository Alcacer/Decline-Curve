namespace Decline_Curve_Analysis
{
    partial class DataInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInput));
            this.DataInputLabel = new System.Windows.Forms.Label();
            this.AnalyseDataButton = new System.Windows.Forms.Button();
            this.DataInputDescriptionLabel = new System.Windows.Forms.Label();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataInputLabel
            // 
            this.DataInputLabel.AutoSize = true;
            this.DataInputLabel.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInputLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.DataInputLabel.Location = new System.Drawing.Point(184, 33);
            this.DataInputLabel.Name = "DataInputLabel";
            this.DataInputLabel.Size = new System.Drawing.Size(302, 36);
            this.DataInputLabel.TabIndex = 0;
            this.DataInputLabel.Text = "Enter Production Data";
            // 
            // AnalyseDataButton
            // 
            this.AnalyseDataButton.BackColor = System.Drawing.Color.Azure;
            this.AnalyseDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyseDataButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyseDataButton.ForeColor = System.Drawing.Color.Black;
            this.AnalyseDataButton.Location = new System.Drawing.Point(269, 392);
            this.AnalyseDataButton.Name = "AnalyseDataButton";
            this.AnalyseDataButton.Size = new System.Drawing.Size(142, 49);
            this.AnalyseDataButton.TabIndex = 2;
            this.AnalyseDataButton.Text = "Analyse Data";
            this.AnalyseDataButton.UseVisualStyleBackColor = false;
            this.AnalyseDataButton.Click += new System.EventHandler(this.AnalyseDataButton_Click);
            // 
            // DataInputDescriptionLabel
            // 
            this.DataInputDescriptionLabel.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInputDescriptionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.DataInputDescriptionLabel.Location = new System.Drawing.Point(371, 111);
            this.DataInputDescriptionLabel.Name = "DataInputDescriptionLabel";
            this.DataInputDescriptionLabel.Size = new System.Drawing.Size(277, 201);
            this.DataInputDescriptionLabel.TabIndex = 3;
            this.DataInputDescriptionLabel.Text = resources.GetString("DataInputDescriptionLabel.Text");
            // 
            // DataListBox
            // 
            this.DataListBox.AllowDrop = true;
            this.DataListBox.BackColor = System.Drawing.Color.White;
            this.DataListBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.ItemHeight = 23;
            this.DataListBox.Location = new System.Drawing.Point(34, 111);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(317, 211);
            this.DataListBox.TabIndex = 4;
            this.DataListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataListBox_DragEnter);
            this.DataListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataListBox_DragDrop);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Azure;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(154, 328);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 32);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // DataInput
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 483);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.DataInputDescriptionLabel);
            this.Controls.Add(this.AnalyseDataButton);
            this.Controls.Add(this.DataInputLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 522);
            this.Name = "DataInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decline Curve Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataInput_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataInputLabel;
        private System.Windows.Forms.Button AnalyseDataButton;
        private System.Windows.Forms.Label DataInputDescriptionLabel;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button browseButton;
    }
}
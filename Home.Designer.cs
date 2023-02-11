namespace Decline_Curve_Analysis
{
    partial class Home
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
            this.HomeHeaderLabel = new System.Windows.Forms.Label();
            this.HomeDescriptionLabel = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeHeaderLabel
            // 
            this.HomeHeaderLabel.AutoSize = true;
            this.HomeHeaderLabel.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeHeaderLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.HomeHeaderLabel.Location = new System.Drawing.Point(32, 40);
            this.HomeHeaderLabel.Name = "HomeHeaderLabel";
            this.HomeHeaderLabel.Size = new System.Drawing.Size(450, 39);
            this.HomeHeaderLabel.TabIndex = 0;
            this.HomeHeaderLabel.Text = "Petroleum Engineering Project";
            // 
            // HomeDescriptionLabel
            // 
            this.HomeDescriptionLabel.AutoSize = true;
            this.HomeDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeDescriptionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.HomeDescriptionLabel.Location = new System.Drawing.Point(68, 118);
            this.HomeDescriptionLabel.Name = "HomeDescriptionLabel";
            this.HomeDescriptionLabel.Size = new System.Drawing.Size(381, 32);
            this.HomeDescriptionLabel.TabIndex = 1;
            this.HomeDescriptionLabel.Text = "Software for Decline Curve Analysis";
            // 
            // ProceedButton
            // 
            this.ProceedButton.BackColor = System.Drawing.Color.Azure;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.ForeColor = System.Drawing.Color.Black;
            this.ProceedButton.Location = new System.Drawing.Point(205, 208);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(97, 45);
            this.ProceedButton.TabIndex = 2;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 311);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.HomeDescriptionLabel);
            this.Controls.Add(this.HomeHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 350);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decline Curve Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeHeaderLabel;
        private System.Windows.Forms.Label HomeDescriptionLabel;
        private System.Windows.Forms.Button ProceedButton;
    }
}
namespace Decline_Curve_Analysis
{
    partial class ColumnNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnNameForm));
            this.SpecifyColumnsLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.ProductionColumnLabel = new System.Windows.Forms.Label();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.ProductionTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpecifyColumnsLabel
            // 
            this.SpecifyColumnsLabel.AutoSize = true;
            this.SpecifyColumnsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpecifyColumnsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecifyColumnsLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SpecifyColumnsLabel.Location = new System.Drawing.Point(48, 9);
            this.SpecifyColumnsLabel.Name = "SpecifyColumnsLabel";
            this.SpecifyColumnsLabel.Size = new System.Drawing.Size(305, 32);
            this.SpecifyColumnsLabel.TabIndex = 0;
            this.SpecifyColumnsLabel.Text = "Specify the Column Names\r\n";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.DaysLabel.Location = new System.Drawing.Point(12, 85);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(198, 21);
            this.DaysLabel.TabIndex = 1;
            this.DaysLabel.Text = "No. of Days Column Name:";
            // 
            // ProductionColumnLabel
            // 
            this.ProductionColumnLabel.AutoSize = true;
            this.ProductionColumnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionColumnLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProductionColumnLabel.Location = new System.Drawing.Point(12, 141);
            this.ProductionColumnLabel.Name = "ProductionColumnLabel";
            this.ProductionColumnLabel.Size = new System.Drawing.Size(194, 21);
            this.ProductionColumnLabel.TabIndex = 3;
            this.ProductionColumnLabel.Text = "Production Column Name:";
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DaysTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.DaysTextBox.Location = new System.Drawing.Point(216, 79);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(175, 27);
            this.DaysTextBox.TabIndex = 4;
            // 
            // ProductionTextbox
            // 
            this.ProductionTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductionTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.ProductionTextbox.Location = new System.Drawing.Point(216, 135);
            this.ProductionTextbox.Name = "ProductionTextbox";
            this.ProductionTextbox.Size = new System.Drawing.Size(175, 27);
            this.ProductionTextbox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SubmitButton.Location = new System.Drawing.Point(158, 182);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(99, 42);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ColumnNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 248);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ProductionTextbox);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.ProductionColumnLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.SpecifyColumnsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColumnNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Specify Columns in File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpecifyColumnsLabel;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label ProductionColumnLabel;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox ProductionTextbox;
        private System.Windows.Forms.Button SubmitButton;
    }
}
namespace TKNPCParts_Layout
{
    partial class License
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
            this.licenseBox = new System.Windows.Forms.RichTextBox();
            this.licenseTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // licenseBox
            // 
            this.licenseBox.Location = new System.Drawing.Point(144, 95);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ReadOnly = true;
            this.licenseBox.Size = new System.Drawing.Size(512, 467);
            this.licenseBox.TabIndex = 6;
            this.licenseBox.Text = "";
            // 
            // licenseTitle
            // 
            this.licenseTitle.AutoSize = true;
            this.licenseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseTitle.Location = new System.Drawing.Point(333, 42);
            this.licenseTitle.Name = "licenseTitle";
            this.licenseTitle.Size = new System.Drawing.Size(120, 32);
            this.licenseTitle.TabIndex = 7;
            this.licenseTitle.Text = "License";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.licenseTitle);
            this.Controls.Add(this.licenseBox);
            this.Name = "License";
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.Controls.SetChildIndex(this.licenseBox, 0);
            this.Controls.SetChildIndex(this.licenseTitle, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox licenseBox;
        private System.Windows.Forms.Label licenseTitle;
    }
}
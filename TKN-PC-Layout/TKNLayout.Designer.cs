namespace TKN_PC_Layout
{
    partial class TKNLayout
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
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.footerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoBox.Image = global::TKN_PC_Layout.Properties.Resources.TKNPCLOGO1;
            this.logoBox.InitialImage = global::TKN_PC_Layout.Properties.Resources.TKNPCLOGO1;
            this.logoBox.Location = new System.Drawing.Point(680, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(120, 100);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // footerText
            // 
            this.footerText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerText.AutoSize = true;
            this.footerText.Location = new System.Drawing.Point(305, 420);
            this.footerText.Name = "footerText";
            this.footerText.Size = new System.Drawing.Size(191, 16);
            this.footerText.TabIndex = 2;
            this.footerText.Text = "Copyright TKN PC Parts 2024 ©";
            // 
            // TKNLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.footerText);
            this.Controls.Add(this.logoBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TKNLayout";
            this.Text = "TKN Tech N\' PC Parts";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label footerText;
    }
}


namespace TKNPCParts_Layout
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // clearCartButton
            // 
            resources.ApplyResources(this.clearCartButton, "clearCartButton");
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // totalTextBox
            // 
            resources.ApplyResources(this.totalTextBox, "totalTextBox");
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.Name = "priceLabel";
            // 
            // itemLabel
            // 
            resources.ApplyResources(this.itemLabel, "itemLabel");
            this.itemLabel.Name = "itemLabel";
            // 
            // priceListBox
            // 
            resources.ApplyResources(this.priceListBox, "priceListBox");
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Name = "priceListBox";
            // 
            // checkoutButton
            // 
            resources.ApplyResources(this.checkoutButton, "checkoutButton");
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // cartListBox
            // 
            resources.ApplyResources(this.cartListBox, "cartListBox");
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Name = "cartListBox";
            // 
            // Cart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.cartListBox, 0);
            this.Controls.SetChildIndex(this.checkoutButton, 0);
            this.Controls.SetChildIndex(this.priceListBox, 0);
            this.Controls.SetChildIndex(this.itemLabel, 0);
            this.Controls.SetChildIndex(this.priceLabel, 0);
            this.Controls.SetChildIndex(this.totalLabel, 0);
            this.Controls.SetChildIndex(this.totalTextBox, 0);
            this.Controls.SetChildIndex(this.clearCartButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ListBox cartListBox;
    }
}
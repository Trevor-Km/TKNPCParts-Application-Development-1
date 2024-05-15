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
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(597, 26);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 89);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(15, 455);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(128, 28);
            this.clearCartButton.TabIndex = 50;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(416, 463);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(158, 20);
            this.totalTextBox.TabIndex = 49;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(350, 463);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 16);
            this.totalLabel.TabIndex = 48;
            this.totalLabel.Text = "TOTAL:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(413, 26);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 16);
            this.priceLabel.TabIndex = 47;
            this.priceLabel.Text = "PRICE";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(12, 26);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(43, 16);
            this.itemLabel.TabIndex = 46;
            this.itemLabel.Text = "ITEM";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(416, 45);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(158, 394);
            this.priceListBox.TabIndex = 45;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(285, 547);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(145, 43);
            this.checkoutButton.TabIndex = 44;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(12, 45);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(398, 394);
            this.cartListBox.TabIndex = 43;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 611);
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
            this.Text = "Cart";
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
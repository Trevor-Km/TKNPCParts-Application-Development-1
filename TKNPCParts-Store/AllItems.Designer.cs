namespace TKNPCParts_Layout
{
    partial class AllItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllItems));
            this.tKNPcPartsDBDataSet = new TKNPCParts_Layout.TKNPcPartsDBDataSet();
            this.tKNPcPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKNPcPartsTableAdapter = new TKNPCParts_Layout.TKNPcPartsDBDataSetTableAdapters.TKNPcPartsTableAdapter();
            this.tableAdapterManager = new TKNPCParts_Layout.TKNPcPartsDBDataSetTableAdapters.TableAdapterManager();
            this.tKNPcPartsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tKNPcPartsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tKNPcPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pCPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peripheralsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termsAndAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsBindingNavigator)).BeginInit();
            this.tKNPcPartsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tKNPcPartsDBDataSet
            // 
            this.tKNPcPartsDBDataSet.DataSetName = "TKNPcPartsDBDataSet";
            this.tKNPcPartsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKNPcPartsBindingSource
            // 
            this.tKNPcPartsBindingSource.DataMember = "TKNPcParts";
            this.tKNPcPartsBindingSource.DataSource = this.tKNPcPartsDBDataSet;
            // 
            // tKNPcPartsTableAdapter
            // 
            this.tKNPcPartsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TKNPcPartsDBTableAdapter = null;
            this.tableAdapterManager.TKNPcPartsTableAdapter = this.tKNPcPartsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TKNPCParts_Layout.TKNPcPartsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tKNPcPartsBindingNavigator
            // 
            this.tKNPcPartsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tKNPcPartsBindingNavigator.BindingSource = this.tKNPcPartsBindingSource;
            this.tKNPcPartsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tKNPcPartsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tKNPcPartsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tKNPcPartsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tKNPcPartsBindingNavigatorSaveItem});
            this.tKNPcPartsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tKNPcPartsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tKNPcPartsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tKNPcPartsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tKNPcPartsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tKNPcPartsBindingNavigator.Name = "tKNPcPartsBindingNavigator";
            this.tKNPcPartsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tKNPcPartsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tKNPcPartsBindingNavigator.TabIndex = 0;
            this.tKNPcPartsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tKNPcPartsBindingNavigatorSaveItem
            // 
            this.tKNPcPartsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tKNPcPartsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tKNPcPartsBindingNavigatorSaveItem.Image")));
            this.tKNPcPartsBindingNavigatorSaveItem.Name = "tKNPcPartsBindingNavigatorSaveItem";
            this.tKNPcPartsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tKNPcPartsBindingNavigatorSaveItem.Text = "Save Data";
            this.tKNPcPartsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tKNPcPartsBindingNavigatorSaveItem_Click);
            // 
            // tKNPcPartsDataGridView
            // 
            this.tKNPcPartsDataGridView.AutoGenerateColumns = false;
            this.tKNPcPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tKNPcPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tKNPcPartsDataGridView.DataSource = this.tKNPcPartsBindingSource;
            this.tKNPcPartsDataGridView.Location = new System.Drawing.Point(0, 174);
            this.tKNPcPartsDataGridView.Name = "tKNPcPartsDataGridView";
            this.tKNPcPartsDataGridView.RowHeadersWidth = 51;
            this.tKNPcPartsDataGridView.RowTemplate.Height = 24;
            this.tKNPcPartsDataGridView.Size = new System.Drawing.Size(800, 220);
            this.tKNPcPartsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemPrice";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // logoBox
            // 
            this.logoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(670, 58);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(130, 110);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 6;
            this.logoBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCPartsToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pCPartsToolStripMenuItem
            // 
            this.pCPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processorsToolStripMenuItem,
            this.graphicsCardsToolStripMenuItem,
            this.motherboardsToolStripMenuItem,
            this.storageDevicesToolStripMenuItem,
            this.peripheralsToolStripMenuItem,
            this.allItemsToolStripMenuItem,
            this.allItemsToolStripMenuItem1});
            this.pCPartsToolStripMenuItem.Name = "pCPartsToolStripMenuItem";
            this.pCPartsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pCPartsToolStripMenuItem.Text = "&PC Parts";
            // 
            // processorsToolStripMenuItem
            // 
            this.processorsToolStripMenuItem.Name = "processorsToolStripMenuItem";
            this.processorsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.processorsToolStripMenuItem.Text = "&Main";
            // 
            // graphicsCardsToolStripMenuItem
            // 
            this.graphicsCardsToolStripMenuItem.Name = "graphicsCardsToolStripMenuItem";
            this.graphicsCardsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.graphicsCardsToolStripMenuItem.Text = "&Graphics Cards";
            // 
            // motherboardsToolStripMenuItem
            // 
            this.motherboardsToolStripMenuItem.Name = "motherboardsToolStripMenuItem";
            this.motherboardsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.motherboardsToolStripMenuItem.Text = "&Motherboards";
            // 
            // storageDevicesToolStripMenuItem
            // 
            this.storageDevicesToolStripMenuItem.Name = "storageDevicesToolStripMenuItem";
            this.storageDevicesToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.storageDevicesToolStripMenuItem.Text = "&Storage Devices";
            // 
            // peripheralsToolStripMenuItem
            // 
            this.peripheralsToolStripMenuItem.Name = "peripheralsToolStripMenuItem";
            this.peripheralsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.peripheralsToolStripMenuItem.Text = "P&eripherals";
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.allItemsToolStripMenuItem.Text = "P&rocessors";
            // 
            // allItemsToolStripMenuItem1
            // 
            this.allItemsToolStripMenuItem1.Name = "allItemsToolStripMenuItem1";
            this.allItemsToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.allItemsToolStripMenuItem1.Text = "&All Items";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termsAndAgreementToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informationToolStripMenuItem.Text = "&Information";
            // 
            // termsAndAgreementToolStripMenuItem
            // 
            this.termsAndAgreementToolStripMenuItem.Name = "termsAndAgreementToolStripMenuItem";
            this.termsAndAgreementToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.termsAndAgreementToolStripMenuItem.Text = "&Terms and Agreement";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.licenseToolStripMenuItem.Text = "&License";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // AllItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tKNPcPartsDataGridView);
            this.Controls.Add(this.tKNPcPartsBindingNavigator);
            this.Name = "AllItems";
            this.Text = "All Items";
            this.Load += new System.EventHandler(this.AllItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsBindingNavigator)).EndInit();
            this.tKNPcPartsBindingNavigator.ResumeLayout(false);
            this.tKNPcPartsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKNPcPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TKNPcPartsDBDataSet tKNPcPartsDBDataSet;
        private System.Windows.Forms.BindingSource tKNPcPartsBindingSource;
        private TKNPcPartsDBDataSetTableAdapters.TKNPcPartsTableAdapter tKNPcPartsTableAdapter;
        private TKNPcPartsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tKNPcPartsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tKNPcPartsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tKNPcPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pCPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peripheralsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termsAndAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
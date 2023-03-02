namespace Final_Project
{
    partial class LunchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LunchForm));
            System.Windows.Forms.Label lunchPriceLabel;
            System.Windows.Forms.Label lunchNameLabel;
            this.fPDataSet = new Final_Project.FPDataSet();
            this.lunchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lunchTableAdapter = new Final_Project.FPDataSetTableAdapters.LunchTableAdapter();
            this.tableAdapterManager = new Final_Project.FPDataSetTableAdapters.TableAdapterManager();
            this.lunchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lunchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lunchDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.lunchPriceTextBox = new System.Windows.Forms.TextBox();
            this.lunchNameTextBox = new System.Windows.Forms.TextBox();
            lunchPriceLabel = new System.Windows.Forms.Label();
            lunchNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchBindingNavigator)).BeginInit();
            this.lunchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lunchBindingSource
            // 
            this.lunchBindingSource.DataMember = "Lunch";
            this.lunchBindingSource.DataSource = this.fPDataSet;
            // 
            // lunchTableAdapter
            // 
            this.lunchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.breakfastTableAdapter = null;
            this.tableAdapterManager.ColdDrinksTableAdapter = null;
            this.tableAdapterManager.DessertTableAdapter = null;
            this.tableAdapterManager.HotDrinkTableAdapter = null;
            this.tableAdapterManager.LunchTableAdapter = this.lunchTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project.FPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lunchBindingNavigator
            // 
            this.lunchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lunchBindingNavigator.BindingSource = this.lunchBindingSource;
            this.lunchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lunchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lunchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lunchBindingNavigatorSaveItem});
            this.lunchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lunchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lunchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lunchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lunchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lunchBindingNavigator.Name = "lunchBindingNavigator";
            this.lunchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lunchBindingNavigator.Size = new System.Drawing.Size(687, 25);
            this.lunchBindingNavigator.TabIndex = 0;
            this.lunchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lunchBindingNavigatorSaveItem
            // 
            this.lunchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lunchBindingNavigatorSaveItem.Enabled = false;
            this.lunchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lunchBindingNavigatorSaveItem.Image")));
            this.lunchBindingNavigatorSaveItem.Name = "lunchBindingNavigatorSaveItem";
            this.lunchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lunchBindingNavigatorSaveItem.Text = "Save Data";
            this.lunchBindingNavigatorSaveItem.Click += new System.EventHandler(this.lunchBindingNavigatorSaveItem_Click);
            // 
            // lunchDataGridView
            // 
            this.lunchDataGridView.AutoGenerateColumns = false;
            this.lunchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lunchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.lunchDataGridView.DataSource = this.lunchBindingSource;
            this.lunchDataGridView.Location = new System.Drawing.Point(12, 28);
            this.lunchDataGridView.Name = "lunchDataGridView";
            this.lunchDataGridView.Size = new System.Drawing.Size(442, 276);
            this.lunchDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LunchId";
            this.dataGridViewTextBoxColumn1.HeaderText = "LunchId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LunchName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LunchName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LunchPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "LunchPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LunchSpecial";
            this.dataGridViewTextBoxColumn4.HeaderText = "LunchSpecial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // viewCartButton
            // 
            this.viewCartButton.Location = new System.Drawing.Point(577, 320);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(99, 37);
            this.viewCartButton.TabIndex = 15;
            this.viewCartButton.Text = "View cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            this.viewCartButton.Click += new System.EventHandler(this.viewCartButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(456, 320);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(561, 191);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantity: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(339, 320);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 37);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lunchPriceLabel
            // 
            lunchPriceLabel.AutoSize = true;
            lunchPriceLabel.Location = new System.Drawing.Point(488, 158);
            lunchPriceLabel.Name = "lunchPriceLabel";
            lunchPriceLabel.Size = new System.Drawing.Size(67, 13);
            lunchPriceLabel.TabIndex = 15;
            lunchPriceLabel.Text = "Lunch Price:";
            // 
            // lunchPriceTextBox
            // 
            this.lunchPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchBindingSource, "LunchPrice", true));
            this.lunchPriceTextBox.Location = new System.Drawing.Point(561, 155);
            this.lunchPriceTextBox.Name = "lunchPriceTextBox";
            this.lunchPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.lunchPriceTextBox.TabIndex = 16;
            // 
            // lunchNameLabel
            // 
            lunchNameLabel.AutoSize = true;
            lunchNameLabel.Location = new System.Drawing.Point(484, 125);
            lunchNameLabel.Name = "lunchNameLabel";
            lunchNameLabel.Size = new System.Drawing.Size(71, 13);
            lunchNameLabel.TabIndex = 16;
            lunchNameLabel.Text = "Lunch Name:";
            // 
            // lunchNameTextBox
            // 
            this.lunchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchBindingSource, "LunchName", true));
            this.lunchNameTextBox.Location = new System.Drawing.Point(561, 122);
            this.lunchNameTextBox.Name = "lunchNameTextBox";
            this.lunchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lunchNameTextBox.TabIndex = 17;
            // 
            // LunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 369);
            this.Controls.Add(lunchNameLabel);
            this.Controls.Add(this.lunchNameTextBox);
            this.Controls.Add(lunchPriceLabel);
            this.Controls.Add(this.lunchPriceTextBox);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.lunchDataGridView);
            this.Controls.Add(this.lunchBindingNavigator);
            this.Name = "LunchForm";
            this.Text = "Lunch Menu";
            this.Load += new System.EventHandler(this.LunchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchBindingNavigator)).EndInit();
            this.lunchBindingNavigator.ResumeLayout(false);
            this.lunchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FPDataSet fPDataSet;
        private System.Windows.Forms.BindingSource lunchBindingSource;
        private FPDataSetTableAdapters.LunchTableAdapter lunchTableAdapter;
        private FPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lunchBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lunchBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lunchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox lunchPriceTextBox;
        private System.Windows.Forms.TextBox lunchNameTextBox;
    }
}
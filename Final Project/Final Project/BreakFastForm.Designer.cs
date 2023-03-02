namespace Final_Project
{
    partial class BreakFastForm
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
            System.Windows.Forms.Label breakfastNameLabel;
            System.Windows.Forms.Label breakfastPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakFastForm));
            this.fPDataSet = new Final_Project.FPDataSet();
            this.breakfastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breakfastTableAdapter = new Final_Project.FPDataSetTableAdapters.breakfastTableAdapter();
            this.tableAdapterManager = new Final_Project.FPDataSetTableAdapters.TableAdapterManager();
            this.breakfastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.breakfastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.breakfastDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.breakfastNameTextBox = new System.Windows.Forms.TextBox();
            this.breakfastPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            breakfastNameLabel = new System.Windows.Forms.Label();
            breakfastPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastBindingNavigator)).BeginInit();
            this.breakfastBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // breakfastNameLabel
            // 
            breakfastNameLabel.AutoSize = true;
            breakfastNameLabel.Location = new System.Drawing.Point(493, 95);
            breakfastNameLabel.Name = "breakfastNameLabel";
            breakfastNameLabel.Size = new System.Drawing.Size(85, 13);
            breakfastNameLabel.TabIndex = 16;
            breakfastNameLabel.Text = "breakfast Name:";
            // 
            // breakfastPriceLabel
            // 
            breakfastPriceLabel.AutoSize = true;
            breakfastPriceLabel.Location = new System.Drawing.Point(497, 128);
            breakfastPriceLabel.Name = "breakfastPriceLabel";
            breakfastPriceLabel.Size = new System.Drawing.Size(81, 13);
            breakfastPriceLabel.TabIndex = 17;
            breakfastPriceLabel.Text = "breakfast Price:";
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // breakfastBindingSource
            // 
            this.breakfastBindingSource.DataMember = "breakfast";
            this.breakfastBindingSource.DataSource = this.fPDataSet;
            // 
            // breakfastTableAdapter
            // 
            this.breakfastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.breakfastTableAdapter = this.breakfastTableAdapter;
            this.tableAdapterManager.ColdDrinksTableAdapter = null;
            this.tableAdapterManager.DessertTableAdapter = null;
            this.tableAdapterManager.HotDrinkTableAdapter = null;
            this.tableAdapterManager.LunchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.FPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // breakfastBindingNavigator
            // 
            this.breakfastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.breakfastBindingNavigator.BindingSource = this.breakfastBindingSource;
            this.breakfastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.breakfastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.breakfastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.breakfastBindingNavigatorSaveItem});
            this.breakfastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.breakfastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.breakfastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.breakfastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.breakfastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.breakfastBindingNavigator.Name = "breakfastBindingNavigator";
            this.breakfastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.breakfastBindingNavigator.Size = new System.Drawing.Size(707, 25);
            this.breakfastBindingNavigator.TabIndex = 0;
            this.breakfastBindingNavigator.Text = "bindingNavigator1";
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
            // breakfastBindingNavigatorSaveItem
            // 
            this.breakfastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.breakfastBindingNavigatorSaveItem.Enabled = false;
            this.breakfastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("breakfastBindingNavigatorSaveItem.Image")));
            this.breakfastBindingNavigatorSaveItem.Name = "breakfastBindingNavigatorSaveItem";
            this.breakfastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.breakfastBindingNavigatorSaveItem.Text = "Save Data";
            this.breakfastBindingNavigatorSaveItem.Click += new System.EventHandler(this.breakfastBindingNavigatorSaveItem_Click);
            // 
            // breakfastDataGridView
            // 
            this.breakfastDataGridView.AutoGenerateColumns = false;
            this.breakfastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breakfastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.breakfastDataGridView.DataSource = this.breakfastBindingSource;
            this.breakfastDataGridView.Location = new System.Drawing.Point(12, 37);
            this.breakfastDataGridView.Name = "breakfastDataGridView";
            this.breakfastDataGridView.Size = new System.Drawing.Size(443, 236);
            this.breakfastDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "breakfastId";
            this.dataGridViewTextBoxColumn1.HeaderText = "breakfastId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "breakfastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "breakfastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "breakfastPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "breakfastPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "breakfast_Special";
            this.dataGridViewTextBoxColumn4.HeaderText = "breakfast_Special";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // viewCartButton
            // 
            this.viewCartButton.Location = new System.Drawing.Point(582, 289);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(99, 37);
            this.viewCartButton.TabIndex = 16;
            this.viewCartButton.Text = "View cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            this.viewCartButton.Click += new System.EventHandler(this.viewCartButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(461, 289);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(344, 289);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 37);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // breakfastNameTextBox
            // 
            this.breakfastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.breakfastBindingSource, "breakfastName", true));
            this.breakfastNameTextBox.Location = new System.Drawing.Point(584, 92);
            this.breakfastNameTextBox.Name = "breakfastNameTextBox";
            this.breakfastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.breakfastNameTextBox.TabIndex = 17;
            // 
            // breakfastPriceTextBox
            // 
            this.breakfastPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.breakfastBindingSource, "breakfastPrice", true));
            this.breakfastPriceTextBox.Location = new System.Drawing.Point(584, 125);
            this.breakfastPriceTextBox.Name = "breakfastPriceTextBox";
            this.breakfastPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.breakfastPriceTextBox.TabIndex = 18;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(584, 158);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantity: ";
            // 
            // BreakFastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 346);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(breakfastPriceLabel);
            this.Controls.Add(this.breakfastPriceTextBox);
            this.Controls.Add(breakfastNameLabel);
            this.Controls.Add(this.breakfastNameTextBox);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.breakfastDataGridView);
            this.Controls.Add(this.breakfastBindingNavigator);
            this.Name = "BreakFastForm";
            this.Text = "Break Fast menu";
            this.Load += new System.EventHandler(this.BreakFastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastBindingNavigator)).EndInit();
            this.breakfastBindingNavigator.ResumeLayout(false);
            this.breakfastBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FPDataSet fPDataSet;
        private System.Windows.Forms.BindingSource breakfastBindingSource;
        private FPDataSetTableAdapters.breakfastTableAdapter breakfastTableAdapter;
        private FPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator breakfastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton breakfastBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView breakfastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox breakfastNameTextBox;
        private System.Windows.Forms.TextBox breakfastPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label1;
    }
}
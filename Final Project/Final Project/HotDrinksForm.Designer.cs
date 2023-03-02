namespace Final_Project
{
    partial class HotDrinksForm
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
            System.Windows.Forms.Label hotDrinkNameLabel;
            System.Windows.Forms.Label hotDrinkPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotDrinksForm));
            this.fPDataSet = new Final_Project.FPDataSet();
            this.hotDrinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotDrinkTableAdapter = new Final_Project.FPDataSetTableAdapters.HotDrinkTableAdapter();
            this.tableAdapterManager = new Final_Project.FPDataSetTableAdapters.TableAdapterManager();
            this.hotDrinkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hotDrinkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hotDrinkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.hotDrinkNameTextBox = new System.Windows.Forms.TextBox();
            this.hotDrinkPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.viewCartButton = new System.Windows.Forms.Button();
            hotDrinkNameLabel = new System.Windows.Forms.Label();
            hotDrinkPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkBindingNavigator)).BeginInit();
            this.hotDrinkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotDrinkNameLabel
            // 
            hotDrinkNameLabel.AutoSize = true;
            hotDrinkNameLabel.Location = new System.Drawing.Point(502, 62);
            hotDrinkNameLabel.Name = "hotDrinkNameLabel";
            hotDrinkNameLabel.Size = new System.Drawing.Size(86, 13);
            hotDrinkNameLabel.TabIndex = 3;
            hotDrinkNameLabel.Text = "Hot Drink Name:";
            // 
            // hotDrinkPriceLabel
            // 
            hotDrinkPriceLabel.AutoSize = true;
            hotDrinkPriceLabel.Location = new System.Drawing.Point(506, 103);
            hotDrinkPriceLabel.Name = "hotDrinkPriceLabel";
            hotDrinkPriceLabel.Size = new System.Drawing.Size(82, 13);
            hotDrinkPriceLabel.TabIndex = 5;
            hotDrinkPriceLabel.Text = "Hot Drink Price:";
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotDrinkBindingSource
            // 
            this.hotDrinkBindingSource.DataMember = "HotDrink";
            this.hotDrinkBindingSource.DataSource = this.fPDataSet;
            // 
            // hotDrinkTableAdapter
            // 
            this.hotDrinkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.breakfastTableAdapter = null;
            this.tableAdapterManager.ColdDrinksTableAdapter = null;
            this.tableAdapterManager.DessertTableAdapter = null;
            this.tableAdapterManager.HotDrinkTableAdapter = this.hotDrinkTableAdapter;
            this.tableAdapterManager.LunchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.FPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotDrinkBindingNavigator
            // 
            this.hotDrinkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotDrinkBindingNavigator.BindingSource = this.hotDrinkBindingSource;
            this.hotDrinkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotDrinkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotDrinkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hotDrinkBindingNavigatorSaveItem});
            this.hotDrinkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotDrinkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotDrinkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotDrinkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotDrinkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotDrinkBindingNavigator.Name = "hotDrinkBindingNavigator";
            this.hotDrinkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotDrinkBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.hotDrinkBindingNavigator.TabIndex = 0;
            this.hotDrinkBindingNavigator.Text = "bindingNavigator1";
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
            // hotDrinkBindingNavigatorSaveItem
            // 
            this.hotDrinkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotDrinkBindingNavigatorSaveItem.Enabled = false;
            this.hotDrinkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotDrinkBindingNavigatorSaveItem.Image")));
            this.hotDrinkBindingNavigatorSaveItem.Name = "hotDrinkBindingNavigatorSaveItem";
            this.hotDrinkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotDrinkBindingNavigatorSaveItem.Text = "Save Data";
            this.hotDrinkBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotDrinkBindingNavigatorSaveItem_Click);
            // 
            // hotDrinkDataGridView
            // 
            this.hotDrinkDataGridView.AutoGenerateColumns = false;
            this.hotDrinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotDrinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hotDrinkDataGridView.DataSource = this.hotDrinkBindingSource;
            this.hotDrinkDataGridView.Location = new System.Drawing.Point(12, 28);
            this.hotDrinkDataGridView.Name = "hotDrinkDataGridView";
            this.hotDrinkDataGridView.Size = new System.Drawing.Size(443, 217);
            this.hotDrinkDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HotDrinkId";
            this.dataGridViewTextBoxColumn1.HeaderText = "HotDrinkId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HotDrinkName";
            this.dataGridViewTextBoxColumn2.HeaderText = "HotDrinkName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HotDrinkPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "HotDrinkPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HotDrink_Special";
            this.dataGridViewTextBoxColumn4.HeaderText = "HotDrink_Special";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(356, 262);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 37);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hotDrinkNameTextBox
            // 
            this.hotDrinkNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotDrinkBindingSource, "HotDrinkName", true));
            this.hotDrinkNameTextBox.Location = new System.Drawing.Point(594, 59);
            this.hotDrinkNameTextBox.Name = "hotDrinkNameTextBox";
            this.hotDrinkNameTextBox.ReadOnly = true;
            this.hotDrinkNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotDrinkNameTextBox.TabIndex = 4;
            // 
            // hotDrinkPriceTextBox
            // 
            this.hotDrinkPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotDrinkBindingSource, "HotDrinkPrice", true));
            this.hotDrinkPriceTextBox.Location = new System.Drawing.Point(594, 100);
            this.hotDrinkPriceTextBox.Name = "hotDrinkPriceTextBox";
            this.hotDrinkPriceTextBox.ReadOnly = true;
            this.hotDrinkPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotDrinkPriceTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity: ";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(594, 143);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(473, 262);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewCartButton
            // 
            this.viewCartButton.Location = new System.Drawing.Point(594, 262);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(99, 37);
            this.viewCartButton.TabIndex = 10;
            this.viewCartButton.Text = "View cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            this.viewCartButton.Click += new System.EventHandler(this.viewCartButton_Click);
            // 
            // HotDrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 319);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(hotDrinkPriceLabel);
            this.Controls.Add(this.hotDrinkPriceTextBox);
            this.Controls.Add(hotDrinkNameLabel);
            this.Controls.Add(this.hotDrinkNameTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hotDrinkDataGridView);
            this.Controls.Add(this.hotDrinkBindingNavigator);
            this.Name = "HotDrinksForm";
            this.Text = "Hot Drinks Menu";
            this.Load += new System.EventHandler(this.HotDrinksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkBindingNavigator)).EndInit();
            this.hotDrinkBindingNavigator.ResumeLayout(false);
            this.hotDrinkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotDrinkDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FPDataSet fPDataSet;
        private System.Windows.Forms.BindingSource hotDrinkBindingSource;
        private FPDataSetTableAdapters.HotDrinkTableAdapter hotDrinkTableAdapter;
        private FPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotDrinkBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hotDrinkBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hotDrinkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox hotDrinkNameTextBox;
        private System.Windows.Forms.TextBox hotDrinkPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewCartButton;
    }
}
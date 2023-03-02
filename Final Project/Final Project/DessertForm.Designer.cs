namespace Final_Project
{
    partial class DessertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessertForm));
            System.Windows.Forms.Label dessertNameLabel;
            System.Windows.Forms.Label dessertPriceLabel;
            this.fPDataSet = new Final_Project.FPDataSet();
            this.dessertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertTableAdapter = new Final_Project.FPDataSetTableAdapters.DessertTableAdapter();
            this.tableAdapterManager = new Final_Project.FPDataSetTableAdapters.TableAdapterManager();
            this.dessertBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dessertBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dessertDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dessertNameTextBox = new System.Windows.Forms.TextBox();
            this.dessertPriceTextBox = new System.Windows.Forms.TextBox();
            dessertNameLabel = new System.Windows.Forms.Label();
            dessertPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingNavigator)).BeginInit();
            this.dessertBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dessertBindingSource
            // 
            this.dessertBindingSource.DataMember = "Dessert";
            this.dessertBindingSource.DataSource = this.fPDataSet;
            // 
            // dessertTableAdapter
            // 
            this.dessertTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.breakfastTableAdapter = null;
            this.tableAdapterManager.ColdDrinksTableAdapter = null;
            this.tableAdapterManager.DessertTableAdapter = this.dessertTableAdapter;
            this.tableAdapterManager.HotDrinkTableAdapter = null;
            this.tableAdapterManager.LunchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.FPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dessertBindingNavigator
            // 
            this.dessertBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dessertBindingNavigator.BindingSource = this.dessertBindingSource;
            this.dessertBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dessertBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dessertBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dessertBindingNavigatorSaveItem});
            this.dessertBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dessertBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dessertBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dessertBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dessertBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dessertBindingNavigator.Name = "dessertBindingNavigator";
            this.dessertBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dessertBindingNavigator.Size = new System.Drawing.Size(657, 25);
            this.dessertBindingNavigator.TabIndex = 0;
            this.dessertBindingNavigator.Text = "bindingNavigator1";
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
            // dessertBindingNavigatorSaveItem
            // 
            this.dessertBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dessertBindingNavigatorSaveItem.Enabled = false;
            this.dessertBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dessertBindingNavigatorSaveItem.Image")));
            this.dessertBindingNavigatorSaveItem.Name = "dessertBindingNavigatorSaveItem";
            this.dessertBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dessertBindingNavigatorSaveItem.Text = "Save Data";
            this.dessertBindingNavigatorSaveItem.Click += new System.EventHandler(this.dessertBindingNavigatorSaveItem_Click);
            // 
            // dessertDataGridView
            // 
            this.dessertDataGridView.AutoGenerateColumns = false;
            this.dessertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dessertDataGridView.DataSource = this.dessertBindingSource;
            this.dessertDataGridView.Location = new System.Drawing.Point(12, 28);
            this.dessertDataGridView.Name = "dessertDataGridView";
            this.dessertDataGridView.Size = new System.Drawing.Size(441, 306);
            this.dessertDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DessertId";
            this.dataGridViewTextBoxColumn1.HeaderText = "DessertId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DessertName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DessertName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DessertPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "DessertPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DessertSpecial";
            this.dataGridViewTextBoxColumn4.HeaderText = "DessertSpecial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // viewCartButton
            // 
            this.viewCartButton.Location = new System.Drawing.Point(543, 351);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(99, 37);
            this.viewCartButton.TabIndex = 20;
            this.viewCartButton.Text = "View cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            this.viewCartButton.Click += new System.EventHandler(this.viewCartButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(422, 351);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(542, 189);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantity: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(305, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 37);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dessertNameLabel
            // 
            dessertNameLabel.AutoSize = true;
            dessertNameLabel.Location = new System.Drawing.Point(459, 124);
            dessertNameLabel.Name = "dessertNameLabel";
            dessertNameLabel.Size = new System.Drawing.Size(77, 13);
            dessertNameLabel.TabIndex = 20;
            dessertNameLabel.Text = "Dessert Name:";
            // 
            // dessertNameTextBox
            // 
            this.dessertNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource, "DessertName", true));
            this.dessertNameTextBox.Location = new System.Drawing.Point(542, 121);
            this.dessertNameTextBox.Name = "dessertNameTextBox";
            this.dessertNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.dessertNameTextBox.TabIndex = 21;
            // 
            // dessertPriceLabel
            // 
            dessertPriceLabel.AutoSize = true;
            dessertPriceLabel.Location = new System.Drawing.Point(463, 158);
            dessertPriceLabel.Name = "dessertPriceLabel";
            dessertPriceLabel.Size = new System.Drawing.Size(73, 13);
            dessertPriceLabel.TabIndex = 21;
            dessertPriceLabel.Text = "Dessert Price:";
            // 
            // dessertPriceTextBox
            // 
            this.dessertPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dessertBindingSource, "DessertPrice", true));
            this.dessertPriceTextBox.Location = new System.Drawing.Point(542, 155);
            this.dessertPriceTextBox.Name = "dessertPriceTextBox";
            this.dessertPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.dessertPriceTextBox.TabIndex = 22;
            // 
            // DessertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(dessertPriceLabel);
            this.Controls.Add(this.dessertPriceTextBox);
            this.Controls.Add(dessertNameLabel);
            this.Controls.Add(this.dessertNameTextBox);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dessertDataGridView);
            this.Controls.Add(this.dessertBindingNavigator);
            this.Name = "DessertForm";
            this.Text = "Dessert Menu";
            this.Load += new System.EventHandler(this.DessertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingNavigator)).EndInit();
            this.dessertBindingNavigator.ResumeLayout(false);
            this.dessertBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FPDataSet fPDataSet;
        private System.Windows.Forms.BindingSource dessertBindingSource;
        private FPDataSetTableAdapters.DessertTableAdapter dessertTableAdapter;
        private FPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dessertBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dessertBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dessertDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox dessertNameTextBox;
        private System.Windows.Forms.TextBox dessertPriceTextBox;
    }
}
namespace Final_Project
{
    partial class ColdDrinkForm
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
            System.Windows.Forms.Label coldDrinkNameLabel;
            System.Windows.Forms.Label coldDrinkPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColdDrinkForm));
            this.fPDataSet = new Final_Project.FPDataSet();
            this.coldDrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coldDrinksTableAdapter = new Final_Project.FPDataSetTableAdapters.ColdDrinksTableAdapter();
            this.tableAdapterManager = new Final_Project.FPDataSetTableAdapters.TableAdapterManager();
            this.coldDrinksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coldDrinksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coldDrinksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.coldDrinkNameTextBox = new System.Windows.Forms.TextBox();
            this.coldDrinkPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            coldDrinkNameLabel = new System.Windows.Forms.Label();
            coldDrinkPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksBindingNavigator)).BeginInit();
            this.coldDrinksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // coldDrinkNameLabel
            // 
            coldDrinkNameLabel.AutoSize = true;
            coldDrinkNameLabel.Location = new System.Drawing.Point(521, 117);
            coldDrinkNameLabel.Name = "coldDrinkNameLabel";
            coldDrinkNameLabel.Size = new System.Drawing.Size(90, 13);
            coldDrinkNameLabel.TabIndex = 13;
            coldDrinkNameLabel.Text = "Cold Drink Name:";
            // 
            // coldDrinkPriceLabel
            // 
            coldDrinkPriceLabel.AutoSize = true;
            coldDrinkPriceLabel.Location = new System.Drawing.Point(525, 150);
            coldDrinkPriceLabel.Name = "coldDrinkPriceLabel";
            coldDrinkPriceLabel.Size = new System.Drawing.Size(86, 13);
            coldDrinkPriceLabel.TabIndex = 14;
            coldDrinkPriceLabel.Text = "Cold Drink Price:";
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coldDrinksBindingSource
            // 
            this.coldDrinksBindingSource.DataMember = "ColdDrinks";
            this.coldDrinksBindingSource.DataSource = this.fPDataSet;
            // 
            // coldDrinksTableAdapter
            // 
            this.coldDrinksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.breakfastTableAdapter = null;
            this.tableAdapterManager.ColdDrinksTableAdapter = this.coldDrinksTableAdapter;
            this.tableAdapterManager.DessertTableAdapter = null;
            this.tableAdapterManager.HotDrinkTableAdapter = null;
            this.tableAdapterManager.LunchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.FPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coldDrinksBindingNavigator
            // 
            this.coldDrinksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coldDrinksBindingNavigator.BindingSource = this.coldDrinksBindingSource;
            this.coldDrinksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coldDrinksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coldDrinksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coldDrinksBindingNavigatorSaveItem});
            this.coldDrinksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coldDrinksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coldDrinksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coldDrinksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coldDrinksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coldDrinksBindingNavigator.Name = "coldDrinksBindingNavigator";
            this.coldDrinksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coldDrinksBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.coldDrinksBindingNavigator.TabIndex = 0;
            this.coldDrinksBindingNavigator.Text = "bindingNavigator1";
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
            // coldDrinksBindingNavigatorSaveItem
            // 
            this.coldDrinksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coldDrinksBindingNavigatorSaveItem.Enabled = false;
            this.coldDrinksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coldDrinksBindingNavigatorSaveItem.Image")));
            this.coldDrinksBindingNavigatorSaveItem.Name = "coldDrinksBindingNavigatorSaveItem";
            this.coldDrinksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coldDrinksBindingNavigatorSaveItem.Text = "Save Data";
            this.coldDrinksBindingNavigatorSaveItem.Click += new System.EventHandler(this.coldDrinksBindingNavigatorSaveItem_Click);
            // 
            // coldDrinksDataGridView
            // 
            this.coldDrinksDataGridView.AutoGenerateColumns = false;
            this.coldDrinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coldDrinksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.coldDrinksDataGridView.DataSource = this.coldDrinksBindingSource;
            this.coldDrinksDataGridView.Location = new System.Drawing.Point(12, 28);
            this.coldDrinksDataGridView.Name = "coldDrinksDataGridView";
            this.coldDrinksDataGridView.Size = new System.Drawing.Size(443, 328);
            this.coldDrinksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ColdDrinkId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ColdDrinkId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ColdDrinkName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ColdDrinkName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ColdDrinkPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "ColdDrinkPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Special_Offer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Special_Offer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // viewCartButton
            // 
            this.viewCartButton.Location = new System.Drawing.Point(617, 362);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(99, 37);
            this.viewCartButton.TabIndex = 13;
            this.viewCartButton.Text = "View cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            this.viewCartButton.Click += new System.EventHandler(this.viewCartButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(496, 362);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(379, 362);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 37);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // coldDrinkNameTextBox
            // 
            this.coldDrinkNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coldDrinksBindingSource, "ColdDrinkName", true));
            this.coldDrinkNameTextBox.Location = new System.Drawing.Point(617, 114);
            this.coldDrinkNameTextBox.Name = "coldDrinkNameTextBox";
            this.coldDrinkNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.coldDrinkNameTextBox.TabIndex = 14;
            // 
            // coldDrinkPriceTextBox
            // 
            this.coldDrinkPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coldDrinksBindingSource, "ColdDrinkPrice", true));
            this.coldDrinkPriceTextBox.Location = new System.Drawing.Point(617, 147);
            this.coldDrinkPriceTextBox.Name = "coldDrinkPriceTextBox";
            this.coldDrinkPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.coldDrinkPriceTextBox.TabIndex = 15;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(617, 180);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantity: ";
            // 
            // ColdDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 419);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(coldDrinkPriceLabel);
            this.Controls.Add(this.coldDrinkPriceTextBox);
            this.Controls.Add(coldDrinkNameLabel);
            this.Controls.Add(this.coldDrinkNameTextBox);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coldDrinksDataGridView);
            this.Controls.Add(this.coldDrinksBindingNavigator);
            this.Name = "ColdDrinkForm";
            this.Text = "Cold Drinks Menu";
            this.Load += new System.EventHandler(this.ColdDrinkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksBindingNavigator)).EndInit();
            this.coldDrinksBindingNavigator.ResumeLayout(false);
            this.coldDrinksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coldDrinksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FPDataSet fPDataSet;
        private System.Windows.Forms.BindingSource coldDrinksBindingSource;
        private FPDataSetTableAdapters.ColdDrinksTableAdapter coldDrinksTableAdapter;
        private FPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coldDrinksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coldDrinksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView coldDrinksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox coldDrinkNameTextBox;
        private System.Windows.Forms.TextBox coldDrinkPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label1;
    }
}
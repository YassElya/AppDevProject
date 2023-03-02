namespace Final_Project
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.specialOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.christmasOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easterOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summerOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackFridayOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.beverageCheckBox = new System.Windows.Forms.CheckBox();
            this.mealCheckBox = new System.Windows.Forms.CheckBox();
            this.hotCheckBox = new System.Windows.Forms.CheckBox();
            this.ColdCheckBox = new System.Windows.Forms.CheckBox();
            this.breakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.dessertCheckBox = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialOffersToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // specialOffersToolStripMenuItem
            // 
            this.specialOffersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.christmasOffersToolStripMenuItem,
            this.easterOffersToolStripMenuItem,
            this.summerOffersToolStripMenuItem,
            this.blackFridayOffersToolStripMenuItem});
            this.specialOffersToolStripMenuItem.Name = "specialOffersToolStripMenuItem";
            this.specialOffersToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.specialOffersToolStripMenuItem.Text = "Special offers";
            // 
            // christmasOffersToolStripMenuItem
            // 
            this.christmasOffersToolStripMenuItem.Name = "christmasOffersToolStripMenuItem";
            this.christmasOffersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.christmasOffersToolStripMenuItem.Text = "Christmas offers";
            this.christmasOffersToolStripMenuItem.Click += new System.EventHandler(this.christmasOffersToolStripMenuItem_Click);
            // 
            // easterOffersToolStripMenuItem
            // 
            this.easterOffersToolStripMenuItem.Name = "easterOffersToolStripMenuItem";
            this.easterOffersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.easterOffersToolStripMenuItem.Text = "Easter offers";
            this.easterOffersToolStripMenuItem.Click += new System.EventHandler(this.easterOffersToolStripMenuItem_Click);
            // 
            // summerOffersToolStripMenuItem
            // 
            this.summerOffersToolStripMenuItem.Name = "summerOffersToolStripMenuItem";
            this.summerOffersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.summerOffersToolStripMenuItem.Text = "Summer offers";
            this.summerOffersToolStripMenuItem.Click += new System.EventHandler(this.summerOffersToolStripMenuItem_Click);
            // 
            // blackFridayOffersToolStripMenuItem
            // 
            this.blackFridayOffersToolStripMenuItem.Name = "blackFridayOffersToolStripMenuItem";
            this.blackFridayOffersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.blackFridayOffersToolStripMenuItem.Text = "Black Friday offers";
            this.blackFridayOffersToolStripMenuItem.Click += new System.EventHandler(this.blackFridayOffersToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutUsToolStripMenuItem1});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.aboutUsToolStripMenuItem.Text = "More";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.aboutUsToolStripMenuItem1.Text = "About us";
            this.aboutUsToolStripMenuItem1.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(274, 40);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(102, 34);
            this.cartButton.TabIndex = 1;
            this.cartButton.Text = "View Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details:";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(275, 380);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(93, 36);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // beverageCheckBox
            // 
            this.beverageCheckBox.AutoSize = true;
            this.beverageCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageCheckBox.Location = new System.Drawing.Point(28, 118);
            this.beverageCheckBox.Name = "beverageCheckBox";
            this.beverageCheckBox.Size = new System.Drawing.Size(129, 30);
            this.beverageCheckBox.TabIndex = 8;
            this.beverageCheckBox.Text = "Beverages";
            this.beverageCheckBox.UseVisualStyleBackColor = true;
            this.beverageCheckBox.CheckedChanged += new System.EventHandler(this.beverageCheckBox_CheckedChanged);
            // 
            // mealCheckBox
            // 
            this.mealCheckBox.AutoSize = true;
            this.mealCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealCheckBox.Location = new System.Drawing.Point(28, 205);
            this.mealCheckBox.Name = "mealCheckBox";
            this.mealCheckBox.Size = new System.Drawing.Size(88, 30);
            this.mealCheckBox.TabIndex = 9;
            this.mealCheckBox.Text = "Meals";
            this.mealCheckBox.UseVisualStyleBackColor = true;
            this.mealCheckBox.CheckedChanged += new System.EventHandler(this.mealCheckBox_CheckedChanged);
            // 
            // hotCheckBox
            // 
            this.hotCheckBox.AutoSize = true;
            this.hotCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotCheckBox.Location = new System.Drawing.Point(200, 139);
            this.hotCheckBox.Name = "hotCheckBox";
            this.hotCheckBox.Size = new System.Drawing.Size(67, 30);
            this.hotCheckBox.TabIndex = 10;
            this.hotCheckBox.Text = "Hot";
            this.hotCheckBox.UseVisualStyleBackColor = true;
            this.hotCheckBox.Visible = false;
            // 
            // ColdCheckBox
            // 
            this.ColdCheckBox.AutoSize = true;
            this.ColdCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdCheckBox.Location = new System.Drawing.Point(200, 88);
            this.ColdCheckBox.Name = "ColdCheckBox";
            this.ColdCheckBox.Size = new System.Drawing.Size(75, 30);
            this.ColdCheckBox.TabIndex = 11;
            this.ColdCheckBox.Text = "Cold";
            this.ColdCheckBox.UseVisualStyleBackColor = true;
            this.ColdCheckBox.Visible = false;
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastCheckBox.Location = new System.Drawing.Point(200, 205);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(121, 30);
            this.breakfastCheckBox.TabIndex = 12;
            this.breakfastCheckBox.Text = "Breakfast";
            this.breakfastCheckBox.UseVisualStyleBackColor = true;
            this.breakfastCheckBox.Visible = false;
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchCheckBox.Location = new System.Drawing.Point(200, 261);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(87, 30);
            this.lunchCheckBox.TabIndex = 13;
            this.lunchCheckBox.Text = "Lunch";
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            this.lunchCheckBox.Visible = false;
            // 
            // dessertCheckBox
            // 
            this.dessertCheckBox.AutoSize = true;
            this.dessertCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertCheckBox.Location = new System.Drawing.Point(200, 317);
            this.dessertCheckBox.Name = "dessertCheckBox";
            this.dessertCheckBox.Size = new System.Drawing.Size(102, 30);
            this.dessertCheckBox.TabIndex = 14;
            this.dessertCheckBox.Text = "Dessert";
            this.dessertCheckBox.UseVisualStyleBackColor = true;
            this.dessertCheckBox.Visible = false;
            // 
            // Timer
            // 
            this.Timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Timer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(135, 44);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(100, 23);
            this.Timer.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 428);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.dessertCheckBox);
            this.Controls.Add(this.lunchCheckBox);
            this.Controls.Add(this.breakfastCheckBox);
            this.Controls.Add(this.ColdCheckBox);
            this.Controls.Add(this.hotCheckBox);
            this.Controls.Add(this.mealCheckBox);
            this.Controls.Add(this.beverageCheckBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Client\'s order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem specialOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem christmasOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easterOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summerOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackFridayOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem1;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.CheckBox beverageCheckBox;
        private System.Windows.Forms.CheckBox mealCheckBox;
        private System.Windows.Forms.CheckBox hotCheckBox;
        private System.Windows.Forms.CheckBox ColdCheckBox;
        private System.Windows.Forms.CheckBox breakfastCheckBox;
        private System.Windows.Forms.CheckBox lunchCheckBox;
        private System.Windows.Forms.CheckBox dessertCheckBox;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
    }
}
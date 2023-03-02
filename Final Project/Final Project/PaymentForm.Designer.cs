namespace Final_Project
{
    partial class PaymentForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.cvvTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.preparationLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalTextBox = new System.Windows.Forms.TextBox();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(237, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(237, 174);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(172, 20);
            this.cardTextBox.TabIndex = 1;
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(237, 295);
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(86, 20);
            this.cvvTextBox.TabIndex = 2;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(237, 253);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(120, 20);
            this.dateTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(237, 212);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(172, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client\'s information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pin number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expiration date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "CVV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name on the card:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(50, 66);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(89, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total to pay: ";
            // 
            // preparationLabel
            // 
            this.preparationLabel.AutoSize = true;
            this.preparationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparationLabel.Location = new System.Drawing.Point(50, 101);
            this.preparationLabel.Name = "preparationLabel";
            this.preparationLabel.Size = new System.Drawing.Size(178, 19);
            this.preparationLabel.TabIndex = 12;
            this.preparationLabel.Text = "Your order will be ready at: ";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(300, 489);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(126, 36);
            this.payButton.TabIndex = 13;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(164, 489);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 36);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel everything";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(32, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(126, 36);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Client\'s Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Street name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "City name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Country name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Postal Code: ";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(138, 366);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(126, 20);
            this.streetTextBox.TabIndex = 21;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(138, 399);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(126, 20);
            this.cityTextBox.TabIndex = 22;
            // 
            // postalTextBox
            // 
            this.postalTextBox.Location = new System.Drawing.Point(283, 389);
            this.postalTextBox.Name = "postalTextBox";
            this.postalTextBox.Size = new System.Drawing.Size(126, 20);
            this.postalTextBox.TabIndex = 24;
            // 
            // orderTimer
            // 
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(138, 435);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(126, 20);
            this.countryTextBox.TabIndex = 23;
            this.countryTextBox.Text = "Canada";
            this.countryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 537);
            this.Controls.Add(this.postalTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.preparationLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "PaymentForm";
            this.Text = "Client\'s info";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox cvvTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label preparationLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postalTextBox;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}
namespace Final_Project
{
    partial class CartForm
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
            this.CartTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartTextBox
            // 
            this.CartTextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartTextBox.Location = new System.Drawing.Point(13, 13);
            this.CartTextBox.Multiline = true;
            this.CartTextBox.Name = "CartTextBox";
            this.CartTextBox.ReadOnly = true;
            this.CartTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CartTextBox.Size = new System.Drawing.Size(397, 288);
            this.CartTextBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(465, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(465, 56);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(465, 101);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(465, 146);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 4;
            this.purchaseButton.Text = "display total";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Enabled = false;
            this.proceedButton.Location = new System.Drawing.Point(465, 191);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 40);
            this.proceedButton.TabIndex = 5;
            this.proceedButton.Text = "Proceed to payment";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 313);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.CartTextBox);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CartTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button proceedButton;
    }
}
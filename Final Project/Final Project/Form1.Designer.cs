namespace Final_Project
{
    partial class FinalProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalProjectForm));
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.question1Label = new System.Windows.Forms.Label();
            this.InterfacePictureBox = new System.Windows.Forms.PictureBox();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InterfacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(82, 352);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(96, 31);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(184, 352);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(96, 31);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.Location = new System.Drawing.Point(9, 52);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(345, 33);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome to Jake\'s café";
            // 
            // question1Label
            // 
            this.question1Label.AutoSize = true;
            this.question1Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.question1Label.Location = new System.Drawing.Point(30, 314);
            this.question1Label.Name = "question1Label";
            this.question1Label.Size = new System.Drawing.Size(302, 25);
            this.question1Label.TabIndex = 3;
            this.question1Label.Text = "Would you like to order something?";
            // 
            // InterfacePictureBox
            // 
            this.InterfacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InterfacePictureBox.Image")));
            this.InterfacePictureBox.Location = new System.Drawing.Point(69, 89);
            this.InterfacePictureBox.Name = "InterfacePictureBox";
            this.InterfacePictureBox.Size = new System.Drawing.Size(225, 213);
            this.InterfacePictureBox.TabIndex = 4;
            this.InterfacePictureBox.TabStop = false;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "English",
            "French",
            "Arabic"});
            this.LanguageComboBox.Location = new System.Drawing.Point(211, 12);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 21);
            this.LanguageComboBox.TabIndex = 5;
            this.LanguageComboBox.Text = "English";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(32, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(2, 21);
            this.timeLabel.TabIndex = 6;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FinalProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 398);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.InterfacePictureBox);
            this.Controls.Add(this.question1Label);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Name = "FinalProjectForm";
            this.Text = "Jake\'s café";
            this.Load += new System.EventHandler(this.FinalProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InterfacePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label question1Label;
        private System.Windows.Forms.PictureBox InterfacePictureBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer Timer;
    }
}


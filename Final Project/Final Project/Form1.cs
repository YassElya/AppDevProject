using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FinalProjectForm : Form
    {
        Thread A;
        public FinalProjectForm()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void open(object obj) {
            Application.Run(new OrderForm());
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            int a = LanguageComboBox.SelectedIndex;
            switch (a)
            {
                case 0:
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        MessageBox.Show("Our restaurant is closed during the weekend. Try Monday.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                        A = new Thread(open);
                        A.SetApartmentState(ApartmentState.STA);
                        A.Start();
                    }
                    break;
                case 1:
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        MessageBox.Show("Notre restaurant n'est pas ouvert les fins de semaine. Essayez lundi.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                        A = new Thread(open);
                        A.SetApartmentState(ApartmentState.STA);
                        A.Start();
                    }
                    break;
                case 2:
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        MessageBox.Show("مطعمنا مغلق في عطلة نهاية الأسبوع. جرب يوم الاثنين.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                        A = new Thread(open);
                        A.SetApartmentState(ApartmentState.STA);
                        A.Start();
                    }
                    break;
            }
        }

        private void FinalProjectForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            Timer.Start();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a=LanguageComboBox.SelectedIndex;
            switch (a) {
                case 0:
                    WelcomeLabel.Text = "Welcome to jake's café.";
                    question1Label.Text = "Would you like to order something?";
                    WelcomeLabel.Location = new Point(9, 52);
                    question1Label.Location = new Point(30, 314);
                    yesButton.Text = "Yes";
                    noButton.Text = "No";
                    break;
                case 1:
                    WelcomeLabel.Text = "Bienvenue à Jake's café.";
                    question1Label.Text = "Aimerais-tu acheter quelque chose?";
                    WelcomeLabel.Location = new Point(5, 52);
                    question1Label.Location = new Point(40, 314);
                    yesButton.Text = "Oui";
                    noButton.Text = "Non";
                    break;
                case 2:
                    WelcomeLabel.Text = ".مرحبا بك في جيك كافي";
                    question1Label.Text = "هل تريد اشتراء شيء ما؟";
                    WelcomeLabel.Location = new Point(40, 52);
                    question1Label.Location = new Point(100, 314);
                    yesButton.Text = "نعم";
                    noButton.Text = "لا";
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }
    }
}

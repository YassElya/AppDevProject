using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Final_Project
{
    public partial class AboutUsForm : Form
    {
        Thread F;
        public void open(object obj)
        {
            Application.Run(new OrderForm());
        }
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            F = new Thread(open);
            F.SetApartmentState(ApartmentState.STA);
            F.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutUsForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }
    }
}

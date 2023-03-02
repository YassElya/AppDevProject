using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class OrderForm : Form
    {
        Thread T;
        public OrderForm()
        {
            InitializeComponent();
        }
        public void open(Object obj)
        {
            Application.Run(new AboutUsForm());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            T = new Thread(open);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Timer.Text = DateTime.Now.ToLongTimeString();
            BackColor = Color.LightBlue;
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            var cart = new CartForm();
            cart.Show();
        }
        private void beverageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ColdCheckBox.Visible = true;
            hotCheckBox.Visible = true;
            if (beverageCheckBox.Checked==false) {
                ColdCheckBox.Visible = false;
                hotCheckBox.Visible = false;
                ColdCheckBox.Checked = false;
                hotCheckBox.Checked = false;
            }
        }

        private void mealCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            breakfastCheckBox.Visible = true;
            lunchCheckBox.Visible = true;
            dessertCheckBox.Visible = true;
            if (mealCheckBox.Checked==false) {
                breakfastCheckBox.Visible = false;
                lunchCheckBox.Visible = false;
                dessertCheckBox.Visible = false;
                breakfastCheckBox.Checked = false;
                lunchCheckBox.Checked = false;
                dessertCheckBox.Checked = false;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (ColdCheckBox.Checked==true) {
                var a = new ColdDrinkForm();
                a.Show();
            }
            if (hotCheckBox.Checked==true) {
                var b = new HotDrinksForm();
                b.Show();
            }
            if (breakfastCheckBox.Checked==true) {
                var c = new BreakFastForm();
                c.Show();
                if (breakfastCheckBox.Checked == true && lunchCheckBox.Checked == true) {
                    c.Close();
                }
                if (Timer.Text.Contains("PM")) {
                    MessageBox.Show("You cannot eat breakfast after 12pm.",String.Empty,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    c.Close();
                }
            }
            if (lunchCheckBox.Checked==true) {
                var d = new LunchForm();
                d.Show();
                if (breakfastCheckBox.Checked == true && lunchCheckBox.Checked == true)
                {
                    d.Close();
                }
                if (Timer.Text.Contains("AM")) {
                    MessageBox.Show("You cannot choose lunch before 12pm.",String.Empty,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    d.Close();
                }
            }
            if (dessertCheckBox.Checked==true) {
                var f=new DessertForm();
                f.Show();
            }
            if (breakfastCheckBox.Checked == true && lunchCheckBox.Checked == true)
            {
                MessageBox.Show("You cannot choose breakfast and lunch at the same time.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text= DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void christmasOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are only available in December.",String.Empty,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void easterOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are only available in April.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void summerOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are only available from June to the end of August.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void blackFridayOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are only available November after American thanksgiving.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

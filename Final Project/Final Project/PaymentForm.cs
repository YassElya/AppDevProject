using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            totalLabel.Text += $" {CartForm.finalTotal:C}";
            orderTimer.Start();
            preparationLabel.Text += DateTime.Now.AddMinutes(30);
            orderTimer.Stop();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var cart = new CartForm();
            cart.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || cardTextBox.Text == "" 
                || passwordTextBox.Text == "" || dateTextBox.Text == "" 
                || cvvTextBox.Text == "" || streetTextBox.Text=="" || cityTextBox.Text=="" 
                || postalTextBox.Text=="")
            {
                MessageBox.Show("Every textbox must filled with data otherwise your payment is not confirmed.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Clear();
                cardTextBox.Clear();
                passwordTextBox.Clear();
                dateTextBox.Clear();
                cvvTextBox.Clear();
                streetTextBox.Clear();
                cityTextBox.Clear();
                postalTextBox.Clear();
            }
            else {
                MessageBox.Show("payment succeeded.",String.Empty,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
            
            
        }

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            orderTimer.Start();
        }
    }
}

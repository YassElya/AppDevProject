using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Final_Project
{
    public partial class CartForm : Form
    {
        Thread t;
        public static decimal finalTotal;
        public CartForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var cart = new CartForm();
            this.Close();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            CartTextBox.Text = "Quantity\tBreverage/meal                        Price per unity    Total price\r\n";
            CartTextBox.Text +=string.Join("",HotDrinksForm.element);
            CartTextBox.Text += string.Join("",ColdDrinkForm.element);
            CartTextBox.Text += string.Join("", BreakFastForm.element);
            CartTextBox.Text += string.Join("", LunchForm.element);
            CartTextBox.Text += string.Join("", DessertForm.element);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            HotDrinksForm.element.Clear();
            ColdDrinkForm.element.Clear();
            BreakFastForm.element.Clear();
            LunchForm.element.Clear();
            DessertForm.element.Clear();
            CartTextBox.Clear();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            decimal finalPrice = 0M;
            decimal hot = 0M;
            decimal breakf = 0M;
            decimal lunch = 0M;
            decimal Dessert = 0M;
            for (int i = 0; i <= ColdDrinkForm.element.Count - 1; i++)
            {
                finalPrice += ColdDrinkForm.sum;
            }
            for (int i = 0; i <= HotDrinksForm.element.Count - 1; i++) {
                hot = HotDrinksForm.sum;
            }
            for (int i = 0; i <= BreakFastForm.element.Count - 1; i++) {
                breakf = BreakFastForm.sum;
            }
            for (int i = 0; i <= LunchForm.element.Count - 1; i++) {
                lunch = LunchForm.sum;
            }
            for (int i = 0; i <= DessertForm.element.Count - 1; i++) {
                Dessert = DessertForm.sum;
            }
            decimal total = finalPrice + hot + breakf + lunch + Dessert;
            decimal tvq = (9.975M / 100) * total;
            decimal tps = (5M / 100) * total;
            finalTotal = total + tps + tvq;
            if (finalTotal >0) {
               proceedButton.Enabled = true;
               CartTextBox.Text += $"--------------------------------------------------------------------------\r\n" +
               $"Subtotal:\t\t\t\t" +
               $"{total:C}\r\n\nTPS (5%):\t\t\t{tps:C}\r\n\nTVQ (9.975%):\t\t\t{tvq:C}\r\n\nTotal:\t\t\t\t{finalTotal:C}";
            }
        }
        private void proceedButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var pay = new PaymentForm();
            pay.Show();
        }
    }
}

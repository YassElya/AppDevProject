using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Final_Project
{
    public partial class LunchForm : Form
    {
        public static decimal totalPrice;
        public static List <string> element = new List<string>();
        List <decimal> prices = new List<decimal>();
        public static decimal sum = 0M;
        public LunchForm()
        {
            InitializeComponent();
        }

        private void lunchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lunchBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPDataSet);

        }

        private void LunchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPDataSet.Lunch' table. You can move, or remove it, as needed.
            this.lunchTableAdapter.Fill(this.fPDataSet.Lunch);
            BackColor = Color.LightBlue;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                throw new NullReferenceException("this textbox cannot be empty.");
            }
            string name =lunchNameTextBox.Text;
            decimal price =decimal.Parse(lunchPriceTextBox.Text);
            int Qt =int.Parse(quantityTextBox.Text);
            totalPrice =price*decimal.Parse(quantityTextBox.Text);
            string output = $"{Qt}\t{name}    {price:c}\t{totalPrice:c}\r\n";
            element.Add(output);
            prices.Add(totalPrice);
            sum = prices.Aggregate((x, y) => x + y);
            quantityTextBox.Clear();
        }

        private void viewCartButton_Click(object sender, EventArgs e)
        {
            var cart = new CartForm();
            cart.Show();
        }
    }
}

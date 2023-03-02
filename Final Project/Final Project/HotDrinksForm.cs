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
    public partial class HotDrinksForm : Form
    {
        public static decimal totalPrice;
        public static List<string> element = new List<string>();
        List<decimal> prices = new List<decimal>();
        public static decimal sum = 0M;
        public HotDrinksForm()
        {
            InitializeComponent();
        }

        private void hotDrinkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotDrinkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPDataSet);

        }

        private void HotDrinksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPDataSet.HotDrink' table. You can move, or remove it, as needed.
            this.hotDrinkTableAdapter.Fill(this.fPDataSet.HotDrink);
            BackColor = Color.LightBlue;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCartButton_Click(object sender, EventArgs e)
        {
            var cart = new CartForm();
            cart.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                throw new NullReferenceException("this textbox cannot be empty.");
            }
            string name =hotDrinkNameTextBox.Text;
            decimal price = decimal.Parse(hotDrinkPriceTextBox.Text);
            int Qt = int.Parse(quantityTextBox.Text);
            totalPrice=price*decimal.Parse(quantityTextBox.Text);
            string output = $"{Qt}\t{name}    {price:c}\t{totalPrice:c}\r\n";
            element.Add(output);
            prices.Add(totalPrice);
            sum = prices.Aggregate((x, y) => x + y);
            quantityTextBox.Clear();
        }
    }
}

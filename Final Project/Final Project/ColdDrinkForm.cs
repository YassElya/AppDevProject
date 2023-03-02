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
    public partial class ColdDrinkForm : Form
    {
        public static decimal totalPrice;
        public static List<string> element = new List<string>();
        List<decimal> prices = new List<decimal>();
        public static decimal sum=0M;
        public ColdDrinkForm()
        {
            InitializeComponent();
        }

        private void coldDrinksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coldDrinksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPDataSet);

        }

        private void ColdDrinkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPDataSet.ColdDrinks' table. You can move, or remove it, as needed.
            this.coldDrinksTableAdapter.Fill(this.fPDataSet.ColdDrinks);
            BackColor = Color.LightBlue;
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
            string name = coldDrinkNameTextBox.Text;
            decimal price = decimal.Parse(coldDrinkPriceTextBox.Text);
            int Qt = int.Parse(quantityTextBox.Text);
            totalPrice=price*decimal.Parse(quantityTextBox.Text);
            string output = $"{Qt}\t{name}    {price:c}\t{totalPrice:c}\r\n";
            element.Add(output);
            prices.Add(totalPrice);
            sum =prices.Aggregate((x,y)=>x+y);
            quantityTextBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

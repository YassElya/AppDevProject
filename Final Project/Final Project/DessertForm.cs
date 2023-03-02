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
    public partial class DessertForm : Form
    {
        public static decimal totalPrice;
        public static List<string> element = new List<string>();
        List<decimal> prices = new List<decimal>();
        public static decimal sum = 0M;
        public DessertForm()
        {
            InitializeComponent();
        }

        private void dessertBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dessertBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fPDataSet);

        }

        private void DessertForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPDataSet.Dessert' table. You can move, or remove it, as needed.
            this.dessertTableAdapter.Fill(this.fPDataSet.Dessert);
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
            string name =dessertNameTextBox.Text;
            decimal price = decimal.Parse(dessertPriceTextBox.Text);
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

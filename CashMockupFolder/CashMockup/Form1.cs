using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMockup
{
    public partial class Form1 : Form
    {
        Order order = new Order();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHBurger_Click(object sender, EventArgs e)
        {
            Product product = new Product("Hamburger", 1.50);
            Add(product);
        }




 

        private void btnCBurger_Click(object sender, EventArgs e)
        {
            Product product = new Product("Cheeseburger", 1.75);
            Add(product);
        }







        public void Add(Product product)
        {
            order.AddToOrder(product);
            lbOrder.Items.Add(product.Name.ToString() + " " + product.Price.ToString());
            tbTotalPrice.Text = "Totale prijs: " + order.totalPrice.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<Product> tempList = new List<Product>();
            foreach (Product product in order.orderList)
            {
                tempList.Add(product);
            }

            foreach (Product product in tempList)
            {
                order.RemoveFromOrder(product); ;
            }

            lbOrder.Items.Clear();
            tbTotalPrice.Text = "Totale prijs: 0";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var toRemove = lbOrder.SelectedIndex;
            order.RemoveFromOrder(order.orderList[toRemove]);
            lbOrder.Items.Remove(lbOrder.SelectedItem);
            tbTotalPrice.Text = "Totale prijs: " + order.totalPrice.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De totale prijs is " + order.totalPrice, "Checkout", MessageBoxButtons.OK);
        }
    }
}

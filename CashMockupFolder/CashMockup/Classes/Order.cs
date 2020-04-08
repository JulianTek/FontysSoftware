using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMockup
{
    public class Order
    {
        public Order()
        {
            orderList = new List<Product>();
            this.totalPrice = 0;
        }

        public Order(double totalPrice)
        {
            orderList = new List<Product>();
            this.totalPrice = totalPrice;
        }
        public List<Product> orderList { get; private set; }
        public double totalPrice { get; private set; }


        public double AddToOrder(Product product)
        {
            orderList.Add(product);
            totalPrice += product.Price;
            return totalPrice;
        }

        public double RemoveFromOrder(Product product)
        {
            orderList.Remove(product);
            totalPrice -= product.Price;
            return totalPrice;
        }
    }

}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMockup.Test
{
    [TestClass]
    public class UnitTest1
    {
        Order order = new Order(4);
        Product product = new Product("Product Test", 1);
        [TestMethod]
        public void AddTest()
        {
            double expected = 5;

            double actual = order.AddToOrder(product);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest()
        {
            double expected = 3;

            double actual = order.RemoveFromOrder(product);

            Assert.AreEqual(expected, actual);
        }
    }
}

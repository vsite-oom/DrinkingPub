using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddItemAddsItemsToTheOrder()
        {
            Pricelist pricelist = new Pricelist("Kod veselog brace");

            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);
            pricelist.AddItem("Ledeni čaj, 0.25 l", 1.75);
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);

            Order order1 = new Order();

            order1.AddItem("Coca Cola, 0.33 l", 3);
            order1.AddItem("Uštrcak, 0.5 l", 1);

            Assert.AreEqual(3, order1.OrderItems[new Item("Coca Cola, 0.33 l", 1.5)]);
            Assert.AreEqual(1, order1.OrderItems[new Item("Uštrcak, 0.5 l", 1.23)]);
        }
    }
}
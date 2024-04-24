using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.ConstrainedExecution;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void TakeOrder_AddsOrderToTable()
        {
            Table table = new Table(1, "test table");
            Order order = new Order();
            order.AddItem("testna kava", 2);

            table.TakeOrder(order);
        }

        [TestMethod]
        public void TotalToPay_WithSingleOrders_CalculatesTotalCorrectly()
        {
            Pricelist pricelist = new Pricelist("testni pub");
            pricelist.AddItem("testna kava", 0.60);
            pricelist.AddItem("testna piva", 1.25);

            Table table = new Table(1, "testni stol");
            Order order = new Order();
            order.AddItem("testna kava", 3);
            order.AddItem("testna piva", 3);

            table.TakeOrder(order);
            double total = table.TotalToPay(pricelist);
            double expectedTotal = 3 * 0.60 + 3 * 1.25;

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void TotalToPay_NotAllowingModifications()
        {
            Pricelist pricelist = new Pricelist("testni pub");
            pricelist.AddItem("vinjak cezar, 0.02 l", 2.23);

            Table table = new Table(1, "testni konobar");
            Order order = new Order();
            order.AddItem("vinjak cezar, 0.02 l", 5);

            table.TakeOrder(order);

            double totalBefore = table.TotalToPay(pricelist);
            double total = table.TotalToPay(pricelist);

            Assert.AreEqual(totalBefore, total);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void Constructor_SetsCorrectProperties()
        {
            int tableId = 1;
            string tableName = "TestName";

            Table tableObject = new Table(tableId, tableName);

            Assert.IsNotNull(tableObject);
            Assert.AreEqual(tableId, tableObject.TableId);
            Assert.AreEqual(tableName, tableObject.Name);
            Assert.IsNotNull(tableObject.TableOrders);
            Assert.AreEqual(0, tableObject.TotalCost);
        }

        [TestMethod]
        public void TakeOrder_AddsOrderToTableOrders()
        {
            Table table = new Table(1, "TestTable");
            Order order = new Order();

            table.TakeOrder(order);

            Assert.AreEqual(1, table.TableOrders.Count);
            Assert.IsTrue(table.TableOrders.Contains(order));
        }

        [TestMethod]
        public void TotalToPay_WithPricelistAndOrder_ReturnsCorrectTotalAmountToPay()
        {
            Pricelist pricelist = new Pricelist("TestingPubName");
            pricelist.AddItem("Item1", 2.50);
            pricelist.AddItem("Item2", 3.75);

            Table table = new Table(1, "TestTable");
            Order order = new Order();
            order.AddItem("Item1", 2);
            order.AddItem("Item2", 1);
            table.TakeOrder(order);

            double totalToPay = table.TotalToPay(pricelist);

            Assert.AreEqual(8.75, totalToPay);
        }

        [TestMethod]
        public void TotalToPay_WithMultipleOrders_ReturnsCorrectTotalAmountToPay()
        {
            Pricelist pricelist = new Pricelist("TestingPubName");
            pricelist.AddItem("Item1", 2.50);
            pricelist.AddItem("Item2", 3.75);

            Table table = new Table(1, "TestTable");
            Order order1 = new Order();
            order1.AddItem("Item1", 2);
            order1.AddItem("Item2", 1);
            table.TakeOrder(order1);

            Order order2 = new Order();
            order2.AddItem("Item1", 1);
            table.TakeOrder(order2);

            double totalToPay = table.TotalToPay(pricelist);

            Assert.AreEqual(11.25, totalToPay);
        }
    }
}
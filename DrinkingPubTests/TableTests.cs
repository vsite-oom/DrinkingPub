using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void TableConstructor_ReturnsNewTableObject()
        {
            Table tableObject = new(1, "TestName");

            Assert.IsNotNull(tableObject);
            Assert.AreEqual(1, tableObject.TableId);
            Assert.AreEqual("TestName", tableObject.Name);
        }

        [TestMethod]
        public void TableTotalToPay_WithPricelistAndOrder_ReturnsTotalAmountToPay()
        {
            Pricelist pricelist = new("TestingPubName");
            pricelist.AddItem("Item1", 2.50);
            pricelist.AddItem("Item2", 1.20);

            Table table1 = new(1, "TestTable");
            Assert.IsNotNull(table1);

            Order newOrder = new Order();
            newOrder.AddItem("Item1", 2);
            newOrder.AddItem("Item2", 10);

            table1.TakeOrder(newOrder);

            Assert.AreEqual(17, table1.TotalToPay(pricelist));
        }

        [TestMethod]
        public void TableTotalToPay_WithAddedOnTopItems_ReturnsTotalAmountToPay()
        {
            Pricelist pricelist = new("TestingPubName");
            pricelist.AddItem("Item1", 2.50);
            pricelist.AddItem("Item2", 1.20);

            Table table1 = new(1, "TestTable");
            Assert.IsNotNull(table1);

            Order newOrder = new Order();
            newOrder.AddItem("Item1", 2);
            newOrder.AddItem("Item2", 10);

            table1.TakeOrder(newOrder);

            Assert.AreEqual(17, table1.TotalToPay(pricelist));

            newOrder.AddItem("Item1", 2);
            newOrder.AddItem("Item2", 5);

            Assert.AreEqual(28, table1.TotalToPay(pricelist));
        }
    }
}
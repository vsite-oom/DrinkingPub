using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddItem_WithValidData_AddsItemCorrectly()

        {
            Order order = new Order();
            string itemName = "testna kava";
            int itemQuantity = 2;

            order.AddItem(itemName, itemQuantity);

            // potrebna konverzija IEnumerable u Dictionary posto IEnumerable ne podrzava metodu ContainsKey
            var itemsDictionary = new Dictionary<string, int>(order.Items);

            //Assert.AreEqual(itemQuantity, order.Items[itemName]);
            //Assert.IsTrue(order.Items.ContainsKey(itemName));

            Assert.AreEqual(itemQuantity, itemsDictionary[itemName]);
            Assert.IsTrue(itemsDictionary.ContainsKey(itemName));

        }

        [TestMethod]
        public void AddItem_WithNullItem_ThrowsArgumentException()
        {
            Order order = new Order();

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(null, 1));
        }

        [TestMethod]
        public void AddItem_EmptyItemName_ThrowsArgumentException()
        {
            Order order = new Order();

            Assert.ThrowsException<ArgumentException>(() => order.AddItem("testna kava", 0));
        }
    }
}
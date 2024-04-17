using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Constructor_ReturnsNewOrderObject()
        {
            Order order = new Order();

            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void AddItem_WithValidNameAndQuantity_ReturnsTrue()
        {
            Order orderObject = new();
            string itemName = "TestingName";
            int itemQuantity = 4;

            Assert.IsTrue(orderObject.AddItem(itemName, itemQuantity));
        }

        [TestMethod]
        public void AddItem_WithEmptyName_ReturnFalse()
        {
            Order order = new Order();
            string itemName = "";
            int itemQuantity = 4;

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(itemName, itemQuantity));
        }

        [TestMethod]
        public void AddItem_WithZeroQuantity_ReturnFalse()
        {
            Order order = new Order();
            string itemName = "TestName";
            int itemQuantity = 0;

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(itemName, itemQuantity));
        }

        [TestMethod]
        public void AddItem_WithNegativeQuantity_ReturnFalse()
        {
            Order order = new Order();
            string itemName = "";
            int itemQuantity = -4;

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(itemName, itemQuantity));
        }

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_ReturnsNewOrderObject()
        {
            Assert.IsNotNull(new Order());
        }

        [TestMethod]
        public void OrderAddItem_WithNameAndQuantity_ReturnsTrueIfItemAdded()
        {
            Order orderObject = new();

            Assert.IsTrue(orderObject.AddItem("TestingName", 4));
        }
    }
}
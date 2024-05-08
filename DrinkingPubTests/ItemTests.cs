using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ConstructorCreatesItemWithNameAndPriceProvided()
        {
            string name = "Uštrcak, 0.5 l";
            double price = 1.23;
            var item = new Item(name, price);

            Assert.AreEqual(name, item.itemName);
            Assert.AreEqual(price, item.itemPrice);
        }
    }
}

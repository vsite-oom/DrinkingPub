using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void ConstructorCreatesPricelistWithNameProvided()
        {
            Pricelist pricelist = new Pricelist("Kod veselog brace");

            Assert.AreEqual("Kod veselog brace", pricelist.PubName);
        }

        [TestMethod]
        public void AddItemAddsItemsToThePricelist()
        {
            Pricelist pricelist = new Pricelist("Kod veselog brace");

            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);

            Assert.AreEqual("Uštrcak, 0.5 l", pricelist["Uštrcak, 0.5 l"].itemName);
            Assert.AreEqual(1.23, pricelist["Uštrcak, 0.5 l"].itemPrice);
            Assert.AreEqual("Coca Cola, 0.33 l", pricelist["Coca Cola, 0.33 l"].itemName);
            Assert.AreEqual(1.5, pricelist["Coca Cola, 0.33 l"].itemPrice);
        }
    }
}

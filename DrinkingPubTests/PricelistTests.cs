using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void Constructor_WithValidPubName_CreatesPricelistObject()
        {
            string pubName = "PubName";
            Pricelist pricelist = new Pricelist(pubName);

            Assert.IsNotNull(pricelist);
            Assert.AreEqual(pubName, pricelist.PubName);
            Assert.IsNotNull(pricelist.ItemsOnMenu);
        }

        [TestMethod]
        public void Constructor_WithNullOrEmptyPubName_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Pricelist(null));
            Assert.ThrowsException<ArgumentException>(() => new Pricelist(""));
        }

        [TestMethod]
        public void AddItem_WithValidItemNameAndPrice_AddsItemToMenu()
        { 
            Pricelist pricelist = new Pricelist("PubName");
            string itemName = "Beer";
            double price = 3.50;

            pricelist.AddItem(itemName, price);

            Assert.IsTrue(pricelist.ItemsOnMenu.ContainsKey(itemName));
            Assert.AreEqual(price, pricelist.ItemsOnMenu[itemName]);
        }

        [TestMethod]
        public void AddItem_WithNullOrEmptyItemName_ThrowsArgumentException()
        {
            Pricelist pricelist = new Pricelist("PubName");
            double price = 3.50;

            Assert.ThrowsException<ArgumentException>(() => pricelist.AddItem(null, price));
            Assert.ThrowsException<ArgumentException>(() => pricelist.AddItem("", price));
        }
    }
}

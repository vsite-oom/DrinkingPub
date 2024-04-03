using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void Constructor_WithEmptyName_ThrowsError()
        {
            Assert.ThrowsException<ArgumentException>(() => new Pricelist(""));
        }

        [TestMethod]
        public void AddItem_WithInvalidName_ThrowsError()
        {
            Pricelist pricelist = new("Birtija");
            var itemPrice = 1.0;

            Assert.ThrowsException<ArgumentException>(() => pricelist.AddItem(null, itemPrice));
        }

        [TestMethod]
        public void AddItem_WithEmptyName_ThrowsError()
        {
            Pricelist pricelist = new("Birtija");
            var itemName = "";
            var itemPrice = 1.0;

            Assert.ThrowsException<ArgumentException>(() => pricelist.AddItem(itemName, itemPrice));
        }

        [TestMethod]
        public void AddItem_WithValidNameAndPrice_AddsItemToPricelist()
        {
            Pricelist pricelist = new("Birtija");
            var itemName = "Beer";
            var itemPrice = 1.0;

            pricelist.AddItem(itemName, itemPrice);

            Assert.AreEqual(itemPrice, pricelist.Items[itemName]);
        }
    }
}
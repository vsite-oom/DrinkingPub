namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void Constructor_WithValidPubName_CreatesPriceListObject()
        {
            string pubName = "testni kafic";

            Pricelist pricelist = new Pricelist(pubName);

            Assert.IsNotNull(pricelist);
            Assert.AreEqual(pubName, pricelist.PubName);
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
            Pricelist pricelist = new Pricelist("testni kafic");
            string itemName = "testna kava";
            double price = 0.60;

            pricelist.AddItem(itemName, price);

            double testPrice = pricelist.GetPrice(itemName);
            Assert.AreEqual(price, testPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GetPrice_WithNonexistentItemName_KeyNotFoundException()
        {
            Pricelist pricelist = new Pricelist("testni kafic");

            pricelist.GetPrice("artikl ne postoji");
        }
    }
}
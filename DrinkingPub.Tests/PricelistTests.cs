using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void CreatePricelistWithNameProvided()
        {
            string ime = "Kafana";
            Pricelist cjenik = new Pricelist(ime);
            Assert.IsTrue(cjenik.pubName == ime);
        }
        [TestMethod]
        public void CreatePricelistWithoutNameProvided()
        {
            Assert.ThrowsException<ArgumentException>(() => new Pricelist(""));
        }
        [TestMethod]
        public void AddItemWithNameAndPriceProvided()
        {
            string imePuba = "Kafana";
            Pricelist cjenik = new Pricelist(imePuba);
            string imeArtikla = "Kokta";
            double cijenaArtikla = 1.5;
            cjenik.AddItem(imeArtikla, cijenaArtikla);
            Assert.AreEqual(cjenik.GetPrice(imeArtikla), cijenaArtikla);
        }
        [TestMethod]
        public void AddItemWithoutNameProvided()
        {
            string imePuba = "Kafana";
            Pricelist cjenik = new Pricelist(imePuba);
            string? imeArtikla = null;
            double cijenaArtikla = 1.5;
            Assert.ThrowsException<ArgumentException>(() => cjenik.AddItem(imeArtikla!, cijenaArtikla));
        }
        [TestMethod]
        public void GetItemNotOnPricelist()
        {
            string imePuba = "Kafana";
            Pricelist cjenik = new Pricelist(imePuba);
            Assert.ThrowsException<ArgumentException>(() => cjenik.GetPrice("Rakija"));
        }
        [TestMethod]
        public void GetNullItemThrowsException()
        {
            string imePuba = "Kafana";
            Pricelist cjenik = new Pricelist(imePuba);
            Assert.ThrowsException<ArgumentException>(() => cjenik.GetPrice(null!));
        }
    }
}
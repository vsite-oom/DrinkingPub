namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class PricelistTests
    {
        [TestMethod]
        public void PricelistConstructor_ReturnsNewObject()
        {
            Pricelist pricelistObject = new("Testing pub name");

            Assert.IsNotNull(pricelistObject);
            Assert.AreEqual("Testing pub name", pricelistObject.PubName);
        }

        [TestMethod]
        public void PricelistAddItem_WithNameAndPrice_ReturnsTrueIfItemIsAdded()
        {
            Pricelist pricelistObject = new("Testing pub name");
            Assert.IsNotNull(pricelistObject);

            Assert.IsTrue(pricelistObject.AddItem("Uštrcak, 0.5 l", 1.23));
            Assert.IsTrue(pricelistObject.AddItem("Coca Cola, 0.33 l", 1.5));
            Assert.IsTrue(pricelistObject.AddItem("Ledeni èaj, 0.25 l", 1.75));
            Assert.IsTrue(pricelistObject.AddItem("Vinjak Cezar, 0.02 l", 2.23));
        }
    }
}
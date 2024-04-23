using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void TotalToPay_WithEmptyOrder_ReturnsZero()
        {
            Pricelist pricelist = new("Birtija");
            Table table = new(1, "John");

            double total = table.TotalToPay(pricelist);

            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void TotalToPay_WithOneItem_ReturnsPriceOfItem()
        {
            Pricelist pricelist = new("Birtija");
            pricelist.AddItem("Beer", 1.0);
            Table table = new(1, "John");
            Order order = new();
            order.AddItem("Beer", 1);
            table.TakeOrder(order);

            double total = table.TotalToPay(pricelist);

            Assert.AreEqual(1.0, total);
        }

        [TestMethod]
        public void TotalToPay_WithTwoItems_ReturnsSumOfPrices()
        {
            Pricelist pricelist = new("Birtija");
            pricelist.AddItem("Beer", 1.0);
            pricelist.AddItem("Wine", 2.0);
            Table table = new(1, "John");
            Order order = new();
            order.AddItem("Beer", 1);
            order.AddItem("Wine", 2);
            table.TakeOrder(order);

            double total = table.TotalToPay(pricelist);

            Assert.AreEqual(5.0, total);
        }

        [TestMethod]
        public void TotalToPay_WithTwoOrders_ReturnsSumOfPrices()
        {
            Pricelist pricelist = new("Birtija");
            pricelist.AddItem("Beer", 1.0);
            pricelist.AddItem("Wine", 2.0);
            Table table = new(1, "John");
            Order order1 = new();
            order1.AddItem("Beer", 1);
            table.TakeOrder(order1);
            Order order2 = new();
            order2.AddItem("Wine", 2);
            table.TakeOrder(order2);

            double total = table.TotalToPay(pricelist);

            Assert.AreEqual(5.0, total);
        }
    }
}
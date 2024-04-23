using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddItem_WithInvalidName_ThrowsError()
        {
            Order order = new();
            var itemQuantity = 1;

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(null, itemQuantity));
        }

        [TestMethod]
        public void AddItem_WithEmptyName_ThrowsError()
        {
            Order order = new();
            var itemName = "";
            var itemQuantity = 1;

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(itemName, itemQuantity));
        }

        [TestMethod]
        public void AddItem_WithInvalidQuantity_ThrowsError()
        {
            Order order = new();
            var itemName = "Beer";

            Assert.ThrowsException<ArgumentException>(() => order.AddItem(itemName, 0));
        }

        [TestMethod]
        public void AddItem_WithValidNameAndQuantity_AddsItemToOrder()
        {
            Order order = new();
            var itemName = "Beer";
            var itemQuantity = 1;

            order.AddItem(itemName, itemQuantity);

            Assert.AreEqual(itemQuantity, order.Items[itemName]);
        }

        [TestMethod]
        public void AddItem_WithExistingItem_AddsQuantityToExistingItem()
        {
            Order order = new();
            var itemName = "Beer";
            var itemQuantity = 1;
            order.AddItem(itemName, itemQuantity);

            order.AddItem(itemName, itemQuantity);

            Assert.AreEqual(itemQuantity * 2, order.Items[itemName]);
        }
    }
}
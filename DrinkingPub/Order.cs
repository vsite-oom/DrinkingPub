namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private Dictionary<string, int> OrderItems = new();

        public Order() { }

        public Dictionary<string, int> GetOrderItems()
        {
            return OrderItems;
        }

        public bool AddItem(string itemName, int quantity)
        {
            if (string.IsNullOrEmpty(itemName))
                throw new ArgumentException("Item name cannot be empty or null", nameof(itemName));
            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be zero or null", nameof(quantity));

            if (OrderItems.ContainsKey(itemName))
                OrderItems[itemName] += quantity;
            else
                OrderItems.Add(itemName, quantity);

            return true;
        }
    }
}

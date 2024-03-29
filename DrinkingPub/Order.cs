namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        public Dictionary<string, double> OrderItems = new();

        public Order() { }

        public bool AddItem(string itemName, double quantity)
        {
            if (OrderItems != null)
            {
                if (OrderItems.ContainsKey(itemName))
                    OrderItems[itemName] += quantity;
                else
                    OrderItems.Add(itemName, quantity);

                return true;
            }
            return false;
        }
    }
}

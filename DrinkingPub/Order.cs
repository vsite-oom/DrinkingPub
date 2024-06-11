namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private Dictionary<string, int> items = [];
        public IReadOnlyDictionary<string, int> Items => items;

        public void AddItem(string name, int quantity)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item in order must be named.");
            }
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be positive.");
            }

            if (items.ContainsKey(name))
            {
                items[name] += quantity;
            }
            else
            {
                items.Add(name, quantity);
            }
        }
    }
}
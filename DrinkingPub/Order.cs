

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private readonly Dictionary<string, int> _items = [];
        public IReadOnlyDictionary<string, int> Items => _items;

        public void AddItem(string name, int quantity)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));

            if(quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0", nameof(quantity));

            if (_items.ContainsKey(name))
                _items[name] += quantity;
            else
                _items.Add(name, quantity);
        }
    }
}

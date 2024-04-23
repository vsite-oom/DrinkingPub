

namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public string PubName { get; }
        private readonly Dictionary<string, double> _items = [];

        public Pricelist(string pubName)
        {
            if (string.IsNullOrEmpty(pubName))
                throw new ArgumentException("Pub name cannot be null or empty", nameof(pubName));

            PubName = pubName;
        }

        public void AddItem(string name, double price)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));

            _items.Add(name, price);
        }

        public double GetPrice(string name)
        {
            if (!_items.ContainsKey(name))
                throw new ArgumentException($"Item {name} not found in pricelist", nameof(name));

            return _items[name];
        }
    }
}

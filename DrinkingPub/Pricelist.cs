namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public string PubName { get; }
        private readonly Dictionary<string, double> MenuItems = new Dictionary<string, double>();

        public Pricelist(string pubName)
        {
            if (string.IsNullOrEmpty(pubName))
            {
                throw new ArgumentException("naziv kafica ne moze biti prazan", nameof(pubName));
            }

            PubName = pubName;
        }

        public void AddItem(string itemName, double price)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("naziv artikla ne moze biti prazan", nameof(itemName));
            }
        
            MenuItems[itemName] = price;
        }

        public double GetPrice(string itemName)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("naziv artikla ne moze biti prazan.", nameof(itemName));
            }

            if (!MenuItems.TryGetValue(itemName, out double price))
            {
                throw new KeyNotFoundException($"artikl '{itemName}' nije pronaden u cijeniku");
            }

            return price;
        }
    }
}

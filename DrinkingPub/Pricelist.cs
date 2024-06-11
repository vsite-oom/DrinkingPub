namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public readonly string pubName;
        private Dictionary<string, double> prices = [];
        public Pricelist(string pubName)
        {
            if (string.IsNullOrEmpty(pubName))
            {
                throw new ArgumentException("Drinking Pub must be named.");
            }
            this.pubName = pubName;
        }

        public void AddItem(string itemName, double itemPrice)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item must be named.");
            }
            prices.Add(itemName, itemPrice);
        }
        public double GetPrice(string itemName)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item must have name.");
            }
            if (!prices.ContainsKey(itemName))
            {
                throw new ArgumentException($"{itemName} does not exist.");
            }
            return prices[itemName];
        }
    }
}
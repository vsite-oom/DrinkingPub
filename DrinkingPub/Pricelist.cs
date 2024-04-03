

namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public string PubName { get; }
        public Dictionary<string, double> Items = [];
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

            Items.Add(name, price);
        }
    }
}

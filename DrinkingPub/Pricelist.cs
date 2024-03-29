namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public readonly string PubName;
        public readonly Dictionary<string, double> ItemsOnMenu;

        public Pricelist(string pubName)
        {
            if (string.IsNullOrEmpty(pubName))
            {
                throw new ArgumentException("Pub name cannot be null or empty.", nameof(pubName));
            }

            PubName = pubName;
            ItemsOnMenu = new();

        }
        public void AddItem(string itemName, double price)
        {
            if(string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("Item name cannot be null or empty.", nameof(PubName));
            }

            ItemsOnMenu?.Add(itemName, price);
        }
    }
}

namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        public readonly string? PubName;
        public readonly Dictionary<string, double> ItemsOnMenu;

        public Pricelist(string pubName)
        {
            PubName = pubName;
            ItemsOnMenu = new();

        }
        public bool AddItem(string itemName, double price)
        {
            try
            {
                ItemsOnMenu?.Add(itemName, price);
                return true;
            }
            catch (NullReferenceException)
            {

                return false;
            }

        }
    }
}

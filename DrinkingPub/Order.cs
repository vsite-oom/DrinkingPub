namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {

        private Dictionary<string, int> items = new Dictionary<string, int>((StringComparer.OrdinalIgnoreCase));

        public Order() { }

        public void AddItem(string itemName, int itemQuantity)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentException("naziv artikla ne moze biti prazan", nameof(itemName));
            }
            if (itemQuantity <= 0)
            {
                throw new ArgumentException("kolicina mora biti veca od 0", nameof(itemQuantity));
            }

            if (items.ContainsKey(itemName))
            {
                items[itemName] += itemQuantity;
            }
            else
            {
                items.Add(itemName, itemQuantity);
            }
        }
        public Dictionary<string, int> Items => items;
    }
}
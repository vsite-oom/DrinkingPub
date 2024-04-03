

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        public Dictionary<string, int> Items = [];

        public void AddItem(string name, int quantity)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));

            if(quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0", nameof(quantity));

            if (Items.ContainsKey(name))
                Items[name] += quantity;
            else
                Items.Add(name, quantity);
        }
    }
}

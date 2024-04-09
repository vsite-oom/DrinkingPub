using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private readonly Dictionary<string, int> items;

        public Order()
        {
            items = new Dictionary<string, int>();
        }

        public void AddItem(string itemName, int quantity)
        {
            if (items.ContainsKey(itemName))
            {
                items[itemName] += quantity;
            }
            else
            {
                items[itemName] = quantity;
            }
        }

        public Dictionary<string, int> Items => items;
    }
}

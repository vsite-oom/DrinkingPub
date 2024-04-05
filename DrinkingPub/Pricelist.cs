using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    internal class Pricelist
    {
        string Name;
        public Dictionary<string, double> Items;

        public Pricelist(string name) {
            Name = name;
            Items = new Dictionary<string, double>();
        }

        public void AddItem(string ItemName, double Price)
        {
            if (!Items.TryAdd(ItemName,Price))
            {
                Items[ItemName] = Price;
            }
        }

        public void RemoveItem(string ItemName) {
            if (Items.TryGetValue(ItemName, out double price))
            {
                Items.Remove(ItemName);
            }
            else
            {
                Console.WriteLine($"Item '{ItemName}' does not exist");
            }
        }
        public void getMenu()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }

}

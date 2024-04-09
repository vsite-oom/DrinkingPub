using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        private readonly Dictionary<string, double> items;

        public Pricelist(string title)
        {
            Title = title;
            items = new Dictionary<string, double>();
        }

        public string Title { get; }

        public void AddItem(string itemName, double price)
        {
            items[itemName] = price;
        }

        public double GetPrice(string itemName)
        {
            if (items.TryGetValue(itemName, out double price))
            {
                return price;
            }
            else
            {
                throw new ArgumentException($"Item '{itemName}' not found in the pricelist.");
            }
        }
    }
}

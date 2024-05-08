using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Pricelist
    {
        // Data members.
        static private string pubName;
        static public List<Item> items;

        // Constructor.
        public Pricelist(string name)
        {
            pubName = name;
            items = new List<Item>();
        }

        // Properties.
        public string PubName
        {
            // Ovo mi treba za PricelistTests.
            get { return pubName; }
        }

        public Item this[string name]
        {
            get
            {
                foreach (var item in items)
                {
                    if (item.itemName == name)
                    {
                        return item;
                    }
                }
                throw new Exception($"Item {name} not found.");
            }
        }

        // Methods.
        public void AddItem(string name, double price)
        {
            items.Add(new Item(name, price));
        }
    }
}

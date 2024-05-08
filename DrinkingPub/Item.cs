using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public struct Item
    {
        public readonly string itemName;
        public readonly double itemPrice;

        public Item(string name, double price)
        {
            itemName = name;
            itemPrice = price;
        }
    }
}

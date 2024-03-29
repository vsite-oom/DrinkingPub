using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public static class Pricelist
    {
        public static readonly string? _pubName;
        public static Dictionary<string, double> ItemsOnMenu = new Dictionary<string, double>();

        public Pricelist(string pubName)
        {
            _pubName = pubName;
        }
        public static void AddItem(string itemName, double price)
        {
            ItemsOnMenu.Add(itemName, price);
        }
    }
}

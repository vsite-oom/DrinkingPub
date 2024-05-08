﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private readonly Dictionary<Item, int> orderItems = new Dictionary<Item, int>();

        //public Dictionary<Item, int> OrderItems
        //{
        //    get
        //    { 
        //        return orderItems; 
        //    } 
        //}
        // ^Ovo svojstvo (property) vraća referencu na interni objekt orderItems,
        // pa preko tog svojstva možete mijenjati sadržaj riječnika. Da spriječite
        // promjene, definirajte svojstvo na sljedeći način:

        //Ispravan način:
        public IEnumerable<KeyValuePair<Item, int>> OrderItems => orderItems.AsEnumerable();

        public void AddItem(string name, int quantity)
        {
            bool found = false;
            foreach (var item in Pricelist.items)
            {
                if (item.itemName == name)
                {
                    found = true;
                    if (orderItems.ContainsKey(item))
                    {
                        orderItems[item] += quantity;
                    }
                    else
                    {
                        orderItems[item] = quantity;
                    }
                    break;
                }
            }
            if (!found)
            {
                throw new Exception($"Item {name} not found.");
            }
        }
    }
}

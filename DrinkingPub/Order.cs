using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        private Dictionary<Item, int> orderItems;

        public Order()
        {
            orderItems = new Dictionary<Item, int>();
        }

        public Dictionary<Item, int> OrderItems
        {
            get
            { 
                return orderItems; 
            } 
        }
        public Item this[string name]
        {
            get
            {
                foreach (var orderItem in orderItems)
                {
                    if (orderItem.Key.itemName == name)
                    {
                        return orderItem.Key;
                    }
                }
                throw new Exception($"Item {name} not found.");
            }
        }

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

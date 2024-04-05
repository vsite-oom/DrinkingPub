using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    internal class Order
    {
        public Dictionary<string, int> order;
        public Order() {
            order = new Dictionary<string, int>();
        }

        public void AddItem(string key, int value)
        {
            if(order.TryGetValue(key,out int currentValue))
            {
                order[key] = currentValue+value;
            }
            else
            {
                order[key] = value;
            }
        }
        public void RemoveItem(string key,int value)
        {
            if(order.TryGetValue(key, out int currentValue)){
                if (currentValue <= value)
                {
                    order.Remove(key);
                }
                else
                {
                    order[key]=currentValue-value;
                }
            }
            else
            {
                Console.WriteLine($"Item '{key}' does not exist");
            }
        }
        public void getOrder()
        {
            foreach (var item in order)
            {
                Console.WriteLine(item);
            }
        }
    }
}

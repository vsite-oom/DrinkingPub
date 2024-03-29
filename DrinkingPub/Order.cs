using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Order
    {
        public Dictionary<string, double> _orderItems = new Dictionary<string, double>();

        public Order() { }

        public void AddItem(string itemName, double itemPrice)
        {
            _orderItems.Add(itemName, itemPrice);
        }
    }
}

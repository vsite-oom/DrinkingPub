using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    internal class Table
    {
        int TableID;
        string Bartender;
        Dictionary<string, int> Bill;

        public Table(int TID, string bt) {
            TableID = TID;
            Bartender = bt;
            Bill= new Dictionary<string, int>();
        }
        public void TakeOrder(Order order) {
            foreach (var item in order.order) {
                if (Bill.TryGetValue(item.Key, out int currentValue))
                {
                    Bill[item.Key] = currentValue + item.Value;
                }
                else
                {
                    Bill[item.Key] = item.Value;
                }
            }
        }
        public void getOrder()
        {
            foreach (var item in Bill)
            {
                Console.WriteLine(item);
            }
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double total = 0;
            foreach (var item in Bill)
            {
                if(pricelist.Items.TryGetValue(item.Key, out double price))
                {
                    total += price*item.Value;
                }
                else
                {
                    Console.WriteLine($"Item '{item.Key}' does not exist");
                }
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        private int tableNumber;
        private string waiterName;
        private List<Order> orders;
        private double totalToPay;

        public List<Order> Orders { get { return orders; } }

        public Table(int number, string name)
        {
            tableNumber = number;
            waiterName = name;
            orders = new List<Order>();
            totalToPay = 0;
        }

        public void TakeOrder(Order order)
        {
            orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            foreach (var order in orders)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    totalToPay += orderItem.Key.itemPrice * orderItem.Value;
                }
            }
            return totalToPay;
        }
    }
}

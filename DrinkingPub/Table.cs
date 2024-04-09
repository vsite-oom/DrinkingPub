using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        private readonly int number;
        private readonly string waiter;
        private Order currentOrder;

        public Table(int number, string waiter)
        {
            this.number = number;
            this.waiter = waiter;
        }

        public void TakeOrder(Order order)
        {
            currentOrder = order;
        }

        public double TotalToPay(Pricelist pricelist)
        {
            if (currentOrder == null)
            {
                throw new InvalidOperationException("No order has been taken for this table.");
            }

            double total = 0;
            foreach (var item in currentOrder.Items)
            {
                double price = pricelist.GetPrice(item.Key);
                total += price * item.Value;
            }
            return total;
        }
    }
}
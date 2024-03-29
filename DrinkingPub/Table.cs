using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        private readonly int _tableId;
        public readonly string Name;

        public List<Order> _tableOrders = new List<Order>();

        public Table(int id, string name)
        {
            _tableId = id;
            Name = name;
        }

        public void TakeOrder(Order inputOrder)
        {
            _tableOrders.Add(inputOrder);
        }
        public double TotalToPay()
        {
            double total = 0;

            foreach (Order inputOrder in _tableOrders)
            {
                foreach (var item in inputOrder._orderItems)
                {
                    total += (item.Value * )
                }
            }
            return total;
        }
    }
}

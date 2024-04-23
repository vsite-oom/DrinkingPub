

namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        public int Number { get; }
        public string Waiter { get; }

        private readonly List<Order> _orders = new();

        public Table(int number, string waiter)
        {
            Number = number;
            Waiter = waiter;
        }

        public void TakeOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            _orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double total = 0;
            foreach (var order in _orders)
            {
                foreach (var item in order.Items)
                {
                    total += pricelist.GetPrice(item.Key) * item.Value;
                }
            }
            return Math.Round(total, 2);
        }
    }
}

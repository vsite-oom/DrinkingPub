

namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        public int Number { get; }
        public string Waiter { get; }

        public List<Order> Orders = new List<Order>();

        public Table(int number, string waiter)
        {
            Number = number;
            Waiter = waiter;
        }

        public void TakeOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            Orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double total = 0;
            foreach (var order in Orders)
            {
                foreach (var item in order.Items)
                {
                    total += item.Value * pricelist.Items[item.Key];
                }
            }
            return Math.Round(total, 2);
        }
    }
}

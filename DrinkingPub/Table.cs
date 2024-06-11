namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        public int table_number;
        public string waiter_name;
        private List<Order> orders = new List<Order>();

        public Table(int table_number, string waiter_name)
        {
            if (table_number <= 0)
            {
                throw new ArgumentException("Table number must be postive.");
            }
            if (string.IsNullOrEmpty(waiter_name))
            {
                throw new ArgumentException("Waiter name is required.");
            }

            this.table_number = table_number;
            this.waiter_name = waiter_name;
        }

        public void TakeOrder(Order order)
        {
            if (order is null)
            {
                throw new ArgumentNullException("Order is null.");
            }

            orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            if (pricelist is null)
            {
                throw new ArgumentNullException("Pricelist is null.");
            }

            double total = 0;
            foreach (Order order in orders)
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
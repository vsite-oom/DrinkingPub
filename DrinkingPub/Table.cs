namespace Vsite.Oom.DrinkingPub
{
    internal class Table
    {
        public Table(int id, string nameOfWaiter)
        {
            Id = id;
            Name = nameOfWaiter;
            Orders = new List<Order>();
        }

        public void TakeOrder(Order order)
        {
            Orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double total = 0;
            foreach (Order order in Orders)
            {
                total += order.GetTotalPrice(pricelist);
            }
            return Math.Round(total,2);
        }

        private int Id;
        private string Name;
        private List<Order> Orders;
    }
}
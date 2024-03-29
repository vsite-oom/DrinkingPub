namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {

        public double TotalCost { get; private set; }
        public int TableId { get; }
        public string Name { get; }
        public List<Order> TableOrders { get; }


        public Table(int id, string name)
        {
            TableId = id;
            Name = name;
            TableOrders = new();
            TotalCost = 0;
        }

        public bool TakeOrder(Order inputOrder)
        {
            try
            {
                TableOrders.Add(inputOrder);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double cost = 0;
            foreach (var orders in TableOrders)
            {
                foreach (var order in orders.OrderItems)
                {
                    if (pricelist.ItemsOnMenu.TryGetValue(order.Key, out double price))
                    {
                        cost += order.Value * price;
                    }
                }
            }

            TotalCost = cost;
            return Math.Round(TotalCost, 2);
        }
    }
}

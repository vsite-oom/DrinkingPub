namespace Vsite.Oom.DrinkingPub
{
    public class Table(int id, string name)
    {
        public readonly int TableId = id;
        public readonly string Name = name;

        public Order? TableOrder;

        public void TakeOrder(Order? inputOrder)
        {
            TableOrder = inputOrder;
        }

        public double TotalToPay(Pricelist pricelist)
        {
            double total = 0;

            if (TableOrder != null)
            {
                foreach (var item in TableOrder.OrderItems)
                {
                    if (pricelist.ItemsOnMenu.TryGetValue(item.Key, out double price))
                    {
                        total += item.Value * price;
                    }
                }
            }

            return total;
        }
    }
}

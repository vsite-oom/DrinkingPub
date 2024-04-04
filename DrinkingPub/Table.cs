namespace Vsite.Oom.DrinkingPub
{
    public class Table
    {
        public int Number {  get; }
        public string WaiterName { get; }
        private List<Order> Orders = new List<Order>();

        public Table(int number, string waiterName)         
        {
            if(number <= 0)
            {
                throw new ArgumentException("broj stola mora biti veci od 0", nameof(number));
            }

            if (string.IsNullOrEmpty(waiterName))
            {
                throw new ArgumentException("ime konobara ne moze biti prazno", nameof(waiterName));
            }

            Number = number;
            WaiterName = waiterName;
        }

        public void TakeOrder(Order order)
        {
            if(order == null)
            {
                throw new ArgumentNullException("narudzba ne moze biti prazna", nameof(order));
            }

            Orders.Add(order);
        }

        public double TotalToPay(Pricelist pricelist)
        {
            if (pricelist == null)
            {
                throw new ArgumentNullException("cjenik ne moze biti null", nameof(pricelist));
            }

            double total = 0;
            foreach (var order in Orders)
            {
                foreach (var item in order.Items)
                {
                    double itemPrice = pricelist.GetPrice(item.Key);
                    total += item.Value * itemPrice;
                }
            }

            return Math.Round(total, 2);
        }
    }
}

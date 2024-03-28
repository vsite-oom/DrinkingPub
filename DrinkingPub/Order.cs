namespace Vsite.Oom.DrinkingPub
{
    internal class Order
    {
        public Order()
        {
        }

        public void AddItem(string item, double howMuch)
        {
            Items.Add(new Tuple<string, double>(item, howMuch));
        }

        public double GetTotalPrice(Pricelist pricelist)
        {
            return Items.Sum(item => pricelist.GetItemPrice(item.Item1) * item.Item2);
        }

        private List<Tuple<string, double>> Items = new();
    }
}
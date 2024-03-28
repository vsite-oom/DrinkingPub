namespace Vsite.Oom.DrinkingPub
{
    internal class Pricelist
    {
        public Pricelist(string name)
        {
            Name = name;
        }

        public void AddItem(string item, double price)
        {
            Items.Add(new Tuple<string, double>(item, price));
        }

        public double GetItemPrice(string item)
        {
            foreach (var tuple in Items)
            {
                if (tuple.Item1 == item) return tuple.Item2;
            }

            throw new ArgumentException($"Nemamo '{item}' trenutno u ponudi.");
        }

        private string Name;
        private List<Tuple<string, double>> Items = new();
    }
}
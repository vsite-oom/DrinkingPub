using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
	public class Pricelist
	{
		private readonly Dictionary<string, double> items;
		public string Name { get; }

		public Pricelist(string name)
		{
			Name = name;
			items = new Dictionary<string, double>();
		}
		public void AddItem(string itemName,  double value)
		{
			items[itemName] = value;
		}
		public double GetPrice(string itemName)
		{
			if (items.TryGetValue(itemName, out double price)) return price;
			else throw new ArgumentException($"'{itemName}' not found in list!");
		}
	}
}

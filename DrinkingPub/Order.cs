using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
	public class Order
	{
		private readonly Dictionary<string, int> items;

		public Order()
		{
			items = new Dictionary<string, int>();
		}

		public void AddItem(string name, int value)
		{
			if(items.ContainsKey(name))
			{
				items[name] += value;
			}
			else
			{
				items[name]=value;
			}
		}
		public Dictionary<string, int> Items => items;
	}
}

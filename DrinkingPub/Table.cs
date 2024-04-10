using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.DrinkingPub
{
	public class Table
	{
		private readonly int broj;
		private readonly string konobar;
		private Order currentOrder;

		public Table(int broj, string konobar)
		{
			this.broj = broj;
			this.konobar = konobar;
		}
		public void TakeOrder(Order order)
		{
			if (currentOrder == null)
			{
				currentOrder = order;
			}
			else
			{
				foreach (var item in order.Items)
				{
					if(currentOrder.Items.ContainsKey(item.Key))
					{
						currentOrder.Items[item.Key] += item.Value;
					}
					else
					{
						currentOrder.Items[item.Key ] = item.Value;
					}
				}
			}
		}
		public double TotalToPay(Pricelist pricelist)
		{
			double total = 0;
			if (currentOrder == null)
			{
				total = 0;
			}
			else
			{
				foreach (var item in currentOrder.Items)
				{
					double price = pricelist.GetPrice(item.Key);
					total += price * item.Value;
				}
			}
			total = Math.Round(total, 2);
			return total;
		}
	}
}

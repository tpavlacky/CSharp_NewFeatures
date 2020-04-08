using System;
using System.Collections.Generic;
using System.Text;

namespace NullableReferenceTypes.Original
{
#nullable disable
	internal class ShoppingBasket
	{
		private List<ShoppingItem> _items;

		public IDiscounter Discounter { get; set; }

		public ShoppingBasket()
		{
			_items = new List<ShoppingItem>();
		}

		public void AddItem(ShoppingItem item)
		{
			_items.Add(item);
		}

		public double CalculateTotalPrice()
		{
			double total = 0.0;
			foreach (var item in _items)
			{
				if(Discounter != null)
				{
					total += Discounter.GetDiscountedPrice(item);
				}
				else
				{
					total += item.Price;
				}
			}

			return total;
		}
	}

	internal interface IDiscounter
	{
		double GetDiscountedPrice(ShoppingItem item);
	}

	internal class ShoppingItem
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
}

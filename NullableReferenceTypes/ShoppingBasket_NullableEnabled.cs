using System.Collections.Generic;

namespace NullableReferenceTypes.Nullable.Enabled
{
// turn on annotations and warnings
#nullable enable
	internal class ShoppingBasket
	{
		//this still looks the same but actually means something completely different
		//With NRT this means that list will not be null AND any of the items in it will not be null
		private List<ShoppingItem> _items;

		//Valid alternatives are:
		//private List<ShoppingItem>? _items;    // => list can be null, but the items in it cannot be null
		//private List<ShoppingItem?> _items;    // => list cannot be null, but the items in it can be null
		//private List<ShoppingItem>? _items;    // => list can be null and items in it can be null

			//Discounter is now nullable, because it is optional 
		public IDiscounter? Discounter { get; set; }

		public ShoppingBasket()
		{
			_items = new List<ShoppingItem>();
		}

		//Method signature is unchanged, but it now explicitly declares that null items should not be added to the basket
		public void AddItem(ShoppingItem item)
		{
			_items.Add(item);
		}

		public double CalculateTotalPrice()
		{
			double total = 0.0;
			foreach (var item in _items)
			{
				if (Discounter != null)
				{
					//would get warning w/o the null check above because it is nullable now
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
		public string Name { get; private set; }
		public double Price { get; private set; }

		public ShoppingItem(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
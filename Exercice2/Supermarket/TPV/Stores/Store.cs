using System.Collections.Generic;

namespace TPV.v1.Stores
{
	public class Store
    {
		private static Store store;

		public static Store Instance()
		{
			if (store == null)
			{
				store = new Store();
			}
			return store;
		}

		private readonly Dictionary<int, Product> _products;

		private Store()
		{
			_products = new Dictionary<int, Product>();
			for (int i = 1; i <= 1000; i++)
			{
				_products.Add(i, new Product(i, 1000 + i));
			}
		}

		public int GetPrice(int id, int units)
		{
			return _products[id].getPrice(units);
		}

		public void Add(int id, int units)
		{
			_products[id].Add(units);
		}

		public void Remove(int id, int units)
		{
			_products[id].Remove(units);
		}
	}
}

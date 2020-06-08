using Manager.v1.Manager;
using System.Collections.Generic;

namespace Manager.v1.Store
{
	public class StoreImplementation : IStore
	{

		private IDictionary<int, Product> productMap;

		public StoreImplementation()
		{
			productMap = new Dictionary<int, Product>();
		}

		public virtual void Add(int code, int amount)
		{
			Product product = productMap[code];
			if (product != null)
			{
				product.Add(amount);
			}
			else
			{
				productMap[code] = new Product(code, amount);
			}
		}

		public virtual bool Exist(int code, int amount)
		{
			Product product = productMap[code];
			if (product == null)
			{
				return false;
			}
			else
			{
				return product.Exist(amount);
			}
		}

		public virtual void Remove(int code, int amount)
		{
			Product product = productMap[code];
			product.Remove(amount);
			if (!product.Exist(1))
			{
				productMap.Remove(code);
			}
		}

		public virtual int[][] List()
		{
			int[][] list = RectangularArrays.RectangularIntArray(productMap.Values.Count, 2);
			int i = 0;
			foreach (int code in productMap.Keys)
			{
				list[i][0] = code;
				list[i][1] = productMap[code].Amount();
				i++;
			}
			return list;
		}

	}

}
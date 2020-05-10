namespace TPV.v1.Stores
{
	public class Product
    {
		private int _price;


		private int _stock;

		public Product(int price, int units)
		{
			this._price = price;
			this._stock = units;
		}

		public int getPrice(int units)
		{
			return _price * units;
		}

		public void Add(int units)
		{
			this._stock += units;
		}

		public void Remove(int units)
		{
			this._stock -= units;
		}
	}
}

using System;

namespace builder.v1
{
    public abstract class Product
    {
		protected Product nextProduct;

		public Product()
		{
			nextProduct = null;
		}

		public void Link(Product product)
		{
			this.nextProduct = product;
		}

		public Product GetNextProduct()
		{
			return nextProduct;
		}

		public abstract void Writeln();
	}
}
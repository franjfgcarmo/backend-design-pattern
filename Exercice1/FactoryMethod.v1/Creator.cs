using System;

namespace FactoryMethod.v1
{
    public abstract class Creator
    {
		public void Operation()
		{
			Console.WriteLine("Antes del factory method");
			FactoryMethod().Write();
			Console.WriteLine("Después del factory method");
		}

		protected abstract IProduct FactoryMethod();
	}
}
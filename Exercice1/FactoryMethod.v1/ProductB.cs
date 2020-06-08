using System;

namespace FactoryMethod.v1
{
    public class ProductB : IProduct
    {
        public void Write()
        {
            Console.WriteLine("Productb");
        }
    }
}
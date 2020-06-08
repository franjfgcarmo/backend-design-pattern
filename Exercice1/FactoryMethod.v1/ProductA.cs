using System;

namespace FactoryMethod.v1
{
    public class ProductA : IProduct
    {
        public void Write()
        {
            Console.WriteLine("ProductA");
        }
    }
} 
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.v1
{
    public class Leaf : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("operation by Leaf");
        }
    }
}

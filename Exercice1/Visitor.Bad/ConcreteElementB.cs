using System;

namespace _Visitor.Bad
{
    public class ConcreteElementB:IElement
    {
		public  void concreteA()
		{
			Console.WriteLine("concreteA by ConcreteElementB");
		}

		public  void concreteB()
		{
			Console.WriteLine("concreteB by ConcreteElementB");
		}

	}
}
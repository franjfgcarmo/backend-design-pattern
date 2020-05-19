using System;

namespace _Visitor.Bad
{
    public class ConcreteElementA: IElement
    {
		public  void concreteA()
		{
			Console.WriteLine("concreteA by ConcreteElementA");
		}

		public  void concreteB()
		{
			Console.WriteLine("concreteB by ConcreteElementA");
		}
	}
}
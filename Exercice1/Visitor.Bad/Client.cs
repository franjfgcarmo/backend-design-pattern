using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.Bad
{
	public class Client
	{

		private void exec()
		{
			//...
			ObjectStructure objectStructure = new ObjectStructure();
			objectStructure.add(new ConcreteElementA());
			objectStructure.add(new ConcreteElementA());
			objectStructure.add(new ConcreteElementB());
			objectStructure.add(new ConcreteElementA());
			//...
			objectStructure.concreteA();
			//...
			objectStructure.concreteB();
		}

		public static void Main(string[] args)
		{
			(new Client()).exec();
		}

	}

}

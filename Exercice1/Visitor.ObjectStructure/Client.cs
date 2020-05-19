using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.ObjectStructure
{
	public class Client
	{

		private void Exec()
		{
			//...
			ObjectStructure objectStructure = new ObjectStructure();
			objectStructure.Add(new ConcreteElementA());
			objectStructure.Add(new ConcreteElementA());
			objectStructure.Add(new ConcreteElementB());
			objectStructure.Add(new ConcreteElementA());
			//...
			objectStructure.Accept(new ConcreteVisitorA());
			//...
			objectStructure.Accept(new ConcreteVisitorA());
			//...
		}

		public static void Main(string[] args)
		{
			new Client().Exec();
		}

	}

}

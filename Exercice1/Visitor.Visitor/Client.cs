using _Visitor.Visitor;
using System.Collections.Generic;
namespace _Visitor.Iterator
{


	public class Client
	{

		private void exec()
		{
			//...
			ObjectStructure objectStructure = new ObjectStructure();
			objectStructure.Add(new ConcreteElementA());
			objectStructure.Add(new ConcreteElementA());
			objectStructure.Add(new ConcreteElementB());
			objectStructure.Add(new ConcreteElementA());
			//...
			new ConcreteVisitorA().VisitObjectStructure(objectStructure);
			//...
			new ConcreteVisitorB().VisitObjectStructure(objectStructure);
		}

		public static void Main(string[] args)
		{
			new Client().exec();
		}

	}


}

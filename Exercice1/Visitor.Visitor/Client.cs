using _Visitor.Visitor;
using System.Collections.Generic;
namespace _Visitor.Iterator
{


	public class Client
	{
		/// <summary>
		/// Aquí el visitor es el que va a visitar a la estructura. La estructura sigue teniendo los datos,
		/// pero en este caso cada visitor es quien decide como visitarlos. El problema que hacerlo así es que 
		/// delego en cada visitor cómo se debe recorrer la estructura de objetos y por tanto me obliga a 
		/// definirlo en cada visitor.
		/// </summary>
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

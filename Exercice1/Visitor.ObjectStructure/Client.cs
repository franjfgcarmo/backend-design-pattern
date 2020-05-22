using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.ObjectStructure
{
	public class Client
	{
		/// <summary>
		/// Hace uso del doble despacho. Aquí la estrutura de objecto es quien marca la pauta para las visitas.
		/// Esta forma de implantarlo, sólo es la estructura de objetos quiente decide por lo que sólo es necesario
		/// implantarlo una vez.
		/// </summary>
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
			Console.WriteLine("-----------------------------------------------");
			objectStructure.Accept(new ConcreteVisitorB());
			//...
			Console.ReadLine();
		}

		public static void Main(string[] args)
		{
			new Client().Exec();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
		public static void Exec()
		{
			// ...

			int code = IO.Instance().ReadInt("Introduzca el número 1: ");
			// ...
			int amount = IO.Instance().ReadInt("Introduzca el número 2: ");
			//...
			var total = code + amount;
			IO.Instance().Writeln("Total = " + total);
			//IO.Instance().Writeln("Cantidad: " + amount);
			Console.ReadKey();

		}
		static void Main(string[] args)
		{
			Exec();

		}
	}
}

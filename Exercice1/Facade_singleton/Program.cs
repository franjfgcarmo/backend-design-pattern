using System;

namespace Facade_singleton
{
    class Program
    {
		public static void Exec()
		{
			// ...

			int code = IO.Instance().ReadInt("Introduzca el código: ");
			// ...
			int amount = IO.Instance().ReadInt("Introduzca la cantidad: ");
			//...
			IO.Instance().Writeln("Código: " + code);
			IO.Instance().Writeln("Cantidad: " + amount);
			Console.ReadKey();

		}
		static void Main(string[] args)
        {
			Exec();

		}
    }
}

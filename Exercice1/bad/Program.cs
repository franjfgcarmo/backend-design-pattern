using System;

namespace bad
{
	class Program
    {
		public static void exec()
		{
		
			// ...
			int code = 0;
			bool ok = false;
			do
			{
				try
				{
					Console.Write("Introduzca el código: ");
					string input = Console.ReadLine();
					code = int.Parse(input);
					ok = true;
				}
				catch (Exception)
				{
					Console.WriteLine("Error de formato entero");
				}
			} while (!ok);

			// ...

			int amount = 0;
			ok = false;
			do
			{
				try
				{
					Console.Write("Introduzca la cantidad: ");
					string input = Console.ReadLine();
					amount = int.Parse(input);
					ok = true;
				}
				catch (Exception)
				{
					Console.WriteLine("Error de formato entero");
				}
			} while (!ok);
			//...
			Console.WriteLine("Código: " + code);
			Console.WriteLine("Cantidad: " + amount);
			Console.ReadKey();
		}
		static void Main(string[] args)
        {
			exec();

		}
    }
}

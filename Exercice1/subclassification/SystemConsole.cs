using System;


namespace FactoryMethod
{
    public class SystemConsole : IO
    {
		public override string ReadString(string title)
		{
			string input = null;
			bool ok = false;
			do
			{
				Write(title);
				try
				{
					input = Console.ReadLine();
					ok = true;
				}
				catch (Exception)
				{
					WriteError("de cadena de caracteres");
				}
			} while (!ok);
			return input;
		}

		public override int ReadInt(string title)
		{
			int input = 0;
			bool ok = false;
			do
			{
				try
				{
					input = int.Parse(ReadString(title));
					ok = true;
				}
				catch (FormatException)
				{
					WriteError("entero");
				}
			} while (!ok);
			return input;
		}

		public override char ReadChar(string title)
		{
			char charValue = ' ';
			bool ok = false;
			do
			{
				string input = ReadString(title);
				if (input.Length != 1)
				{
					WriteError("caracter");
				}
				else
				{
					charValue = input[0];
					ok = true;
				}
			} while (!ok);
			return charValue;
		}

		public override void Writeln()
		{
			Console.WriteLine();
		}

		public override void Write(string @string)
		{
			Console.Write(@string);
		}

		public override void Writeln(string @string)
		{
			Console.WriteLine(@string);
		}

		private void WriteError(string formato)
		{
			Console.WriteLine("ERROR DE FORMATO! " + "Introduzca un valor con formato " + formato + ".");
		}
	}
}

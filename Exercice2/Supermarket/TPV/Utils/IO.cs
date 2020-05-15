using System;

namespace TPV.v1.Utils
{
	public class IO
	{
		private static IO _io;
		public static IO Instance()
		{
			if (_io != null)
			{
				_io = new IO();
			}
			return _io;
		}
		private IO() { }
		public string ReadString(string title)
		{
			string input = null;
			var ok = false;
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

		public int ReadInt(string title)
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
				catch (Exception)
				{
					WriteError("entero");
				}
			} while (!ok);
			return input;
		}

		public char ReadChar(string title)
		{
			char charValue = ' ';
			bool ok = false;
			do
			{
				var input = ReadString(title);
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

		public void Writeln() => Console.WriteLine();

		public void Write(string @string) => Console.WriteLine(@string);

		public void Writeln(string @string) => Console.WriteLine(@string);

		private void WriteError(string formato) => Console.WriteLine($"ERROR DE FORMATO! Introduzca un valor con formato {formato}.");
	}
}

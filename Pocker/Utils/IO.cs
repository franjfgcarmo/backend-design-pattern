using System;
using System.IO;

namespace Poker.Utils
{

	public class IO
	{

		private static IO io;

		public static IO instance()
		{
			if (io == null)
			{
				io = new IO();
			}
			return io;
		}

		private IO()
		{

		}

		private StreamReader bufferedReader = new StreamReader(System.in);

		public virtual string readString(string title)
		{
			string input = null;
			bool ok = false;
			do
			{
				this.write(title);
				try
				{
					input = bufferedReader.ReadLine();
					ok = true;
				}
				catch (IOException)
				{
					this.writeError("de cadena de caracteres");
				}
			} while (!ok);
			return input;
		}

		public virtual int readInt(string title)
		{
			int input = 0;
			bool ok = false;
			do
			{
				try
				{
					input = int.Parse(this.readString(title));
					ok = true;
				}
				catch (System.FormatException)
				{
					this.writeError("entero");
				}
			} while (!ok);
			return input;
		}

		public virtual char readChar(string title)
		{
			char charValue = ' ';
			bool ok = false;
			do
			{
				string input = this.readString(title);
				if (input.Length != 1)
				{
					this.writeError("caracter");
				}
				else
				{
					charValue = input[0];
					ok = true;
				}
			} while (!ok);
			return charValue;
		}

		public virtual void writeln()
		{
			Console.WriteLine();
		}

		public virtual void write(string @string)
		{
			Console.Write(@string);
		}

		public virtual void writeln(string @string)
		{
			Console.WriteLine(@string);
		}

		private void writeError(string formato)
		{
			Console.WriteLine("ERROR DE FORMATO! " + "Introduzca un valor con formato " + formato + ".");
		}
	}

}
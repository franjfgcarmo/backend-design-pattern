using System;
using System.Configuration;

namespace FactoryMethod
{
	public abstract class IO
    {
		// Singleton. Lazy loding
		private static IO io;
		public static IO Instance()
		{
			if (io == null)
			{
				string line = IO.SingletonConfigure;
				try
				{
					io = (IO)(System.Activator.CreateInstance(Type.GetType("FactoryMethod." + line)));
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
					Console.Write(e.StackTrace);
				}
			}
			return io;
		}

		private static string SingletonConfigure
		{
			get
			{
				string line = "";
				try
				{

					line = ConfigurationManager.AppSettings["factoryMethod"];
				}
				catch (Exception ex)
				{
					Console.WriteLine("IOException al leer: " + ex.Message);
				}
				
				return line;
			}
		}
		protected IO() { }

		public abstract string ReadString(string title);

		public abstract int ReadInt(string title);

		public abstract char ReadChar(string title);

		public abstract void Writeln();

		public abstract void Write(string @string);

        public abstract void Writeln(string @string);

	}
}

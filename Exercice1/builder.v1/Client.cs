	using System;
using System.Collections.Generic;
using System.Text;

namespace builder.v1
{
    public class Client
    {
		private void exec()
		{
			//...
			Director director = new Director();
			//...
			director.Set(new ConcreteBuilderA());
			director.Construct().Writeln();
			//...
			director.Set(new ConcreteBuilderB());
			director.Construct().Writeln();
			//...
		}

		public static void Main(String[] args)
		{
			new Client().exec();
		}
	}
}

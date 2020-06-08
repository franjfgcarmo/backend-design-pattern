using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.v1
{
    public class Client
    {
		private void exec()
		{
			//...
			Creator creator;
			//...
			creator = new ConcreteCreatorA();
			creator.Operation();
			//...
			creator = new ConcreteCreatorB();
			creator.Operation();
			//...
		}

		public static void Main(String[] arg)
		{
			new Client().exec();
		}
	}
}

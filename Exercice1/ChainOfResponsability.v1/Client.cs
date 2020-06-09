using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability.v1
{
    public class Client
    {
		private void Exec()
		{
			//...
			//We build the chain of responsability.
			Handler handler = new ConcreteHandlerA(
					new ConcreteHandlerA(
					new ConcreteHandlerB()));
			//...
			handler.HandlerRequest();
		}

		public static void Main(String[] args)
		{
			new Client().Exec();
		}
	}
}

using System;

namespace ChainOfResponsability.v1
{
    public class ConcreteHandlerA : Handler
    {
		public ConcreteHandlerA(Handler nextHandler):base(nextHandler)
		{
		
		}
		public override void HandlerRequest()
        {
			Random random = new Random((int)DateTimeHelper.CurrentUnixTimeMillis());
			if (random.Next(10) <= 7)
			{
				Console.WriteLine("Decide ConcreteHandlerA");
			}
			else
			{
				nextHandler.HandlerRequest();
			}
		}		

	}
}
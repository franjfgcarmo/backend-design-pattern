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
			//Aqui  si es menor que tres, tomo yo la responsabilidad, sino,
			//paso la responsabilidad al siguiente que puede ser uno del mismo tipo que yo	o de diferente tipo.
			Random random = new Random((int)DateTimeHelper.CurrentUnixTimeMillis());
			if (random.Next(10) <= 3)
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
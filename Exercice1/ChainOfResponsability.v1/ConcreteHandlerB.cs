using System;

namespace ChainOfResponsability.v1
{
    public class ConcreteHandlerB : Handler
    {
        public ConcreteHandlerB():base(null)
        {
        }
        public override void HandlerRequest()
        {
            //Decido yo que soy el último.
            Console.WriteLine("Decide ConcreteHandlerB");
        }
    }
}
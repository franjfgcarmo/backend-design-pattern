using System;

namespace ChainOfResponsability.v1
{
    public abstract class Handler
    {
		protected Handler nextHandler;

		protected Handler(Handler nextHandler)
		{
			this.nextHandler = nextHandler;
		}
		public abstract void HandlerRequest();
	}
}
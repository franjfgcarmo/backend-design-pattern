using Manager.v1.Manager;
using System;

namespace Manager.v1.Dispatchers
{    
    public class RemoveDispatcher : Dispatcher
	{

		public RemoveDispatcher(IStore store, Server server) : base(store, server)
		{
		}

		public override void Dispatch()
		{
			try
			{
				int code = int.Parse(server.ReadLine());
				int amount = int.Parse(server.ReadLine());
				store.Remove(code, amount);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}

		public override Dispatcher Clone()
		{
			return new RemoveDispatcher(store, server);
		}
	}

}
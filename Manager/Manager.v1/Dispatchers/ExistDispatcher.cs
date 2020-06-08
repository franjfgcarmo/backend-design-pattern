using Manager.v1.dispatchers;
using Manager.v1.Dispatchers;
using Manager.v1.Manager;
using System;

namespace Manager.v1.dispatchers
{
    public class ExistDispatcher : Dispatcher
	{

		public ExistDispatcher(IStore store, Server server) : base(store, server)
		{
		}

		public override void Dispatch()
		{
			try
			{
				int code = int.Parse(server.ReadLine());
				int amount = int.Parse(server.ReadLine());
				server.Println(store.Exist(code, amount));
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}

		public override Dispatcher Clone()
		{
			return new ExistDispatcher(store, server);
		}
	}

}
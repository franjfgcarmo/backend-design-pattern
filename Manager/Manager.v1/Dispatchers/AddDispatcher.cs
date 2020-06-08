using Manager.v1.Manager;
using System;

namespace Manager.v1.Dispatchers
{
	public class AddDispatcher : Dispatcher
	{
		public AddDispatcher(IStore store, Server server) : base(store, server)
		{
		}

		public override void Dispatch()
		{
			try
			{
				var code = int.Parse(server.ReadLine());
				var amount = int.Parse(server.ReadLine());
				store.Add(code, amount);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.ToString());
				Console.Write(ex.StackTrace);
			}
		}

		public override Dispatcher Clone()
		{
			return new AddDispatcher(store, server);
		}

	}

}
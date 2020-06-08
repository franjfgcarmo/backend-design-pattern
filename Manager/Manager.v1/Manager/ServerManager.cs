using designPatterns.exercises.n3_manager.v1.dispatchers;
using Manager.v1.Store;
using System;

namespace Manager.v1.Manager
{
	public class ServerManager
	{

		private readonly IStore store;

		private readonly Server server;

		private DispatcherPrototype dispatcherPrototype;

		public ServerManager()
		{
			store = new StoreImplementation();
			server = new Server();
			dispatcherPrototype = new DispatcherPrototype(store, server);
		}

		private void serve()
		{
			FrameType frameType = null;
			do
			{
				string @string = server.ReadLine();
				Console.WriteLine("llego por socket: " + @string);
				frameType = FrameType.Parser(@string);
				if (frameType != FrameType.CLOSE)
				{
					dispatcherPrototype.dispatch(frameType);
				}
			} while (frameType != FrameType.CLOSE);
			server.Close();
		}

		public static void Main(string[] args)
		{
			(new ServerManager()).serve();
		}

	}

}
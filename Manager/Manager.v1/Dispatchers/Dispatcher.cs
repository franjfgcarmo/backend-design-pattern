
using Manager.v1.Manager;

namespace Manager.v1.Dispatchers
{
	public abstract class Dispatcher
	{

		protected internal IStore store;

		protected internal Server server;

		public Dispatcher(IStore store, Server server)
		{
			this.store = store;
			this.server = server;
		}

		public abstract void Dispatch();

		public abstract Dispatcher Clone();
	}

}
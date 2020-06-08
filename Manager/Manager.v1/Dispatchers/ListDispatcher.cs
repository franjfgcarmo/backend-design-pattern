using Manager.v1.Manager;

namespace Manager.v1.Dispatchers
{
    public class ListDispatcher : Dispatcher
	{

		public ListDispatcher(IStore store, Server server) : base(store, server)
		{
		}

		public override void Dispatch()
		{
			int[][] result = store.list();
			server.Println(result.Length);
			foreach (int[] product in result)
			{
				server.Println(product[0]);
				server.Println(product[1]);
			}
		}

		public override Dispatcher Clone()
		{
			return new ListDispatcher(store, server);
		}
	}

}
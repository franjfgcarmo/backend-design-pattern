using Manager.v1.Store;

namespace Manager.v1.Manager
{
	public class ClientManager : Manager
	{

		protected internal override IStore CreateStore()
		{
			return new StoreProxy();
		}

		public override void Manage()
		{
			base.Manage();
			((StoreProxy) store).close();
		}

		public static void Main(string[] args)
		{
			(new ClientManager()).Manage();
		}

	}

}
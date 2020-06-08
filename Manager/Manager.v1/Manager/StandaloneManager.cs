using Manager.v1.Store;

namespace Manager.v1.Manager
{
	public class StandaloneManager : Manager
	{

		protected internal override IStore CreateStore()
		{
			return new StoreImplementation();
		}

		public static void Main(string[] args)
		{
			(new StandaloneManager()).Manage();
		}

	}

}
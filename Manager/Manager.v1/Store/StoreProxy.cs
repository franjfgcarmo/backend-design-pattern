using Manager.v1.Manager;

namespace Manager.v1.Store
{
	public class StoreProxy : IStore
	{

		private Client client;

		public StoreProxy()
		{
			client = new Client();
		}

		public virtual void Add(int code, int amount)
		{
			client.Println(FrameType.ADD.ToString());
			client.Println(code);
			client.Println(amount);
		}

		public virtual bool Exist(int code, int amount)
		{
			client.Println(FrameType.EXIST.ToString());
			client.Println(code);
			client.Println(amount);
			return client.ReadBoolean();
		}

		public virtual void Remove(int code, int amount)
		{
			client.Println(FrameType.REMOVE.ToString());
			client.Println(code);
			client.Println(amount);
		}

		public virtual int[][] List()
		{
			client.Println(FrameType.LIST.ToString());
			int[][] result = new int[0][2];
				int lines = client.ReadInt();
				result = RectangularArrays.RectangularIntArray(lines, 2);
				for (int i = 0; i < lines; i++)
				{
					result[i][0] = client.ReadInt();
					result[i][1] = client.ReadInt();
				}
			return result;
		}

		public virtual void close()
		{
			client.close();
		}

	}

}
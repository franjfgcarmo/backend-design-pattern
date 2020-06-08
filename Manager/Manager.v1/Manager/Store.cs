namespace Manager.v1.Manager
{
	public interface IStore
	{

		void Add(int code, int amount);

		bool Exist(int code, int amount);

		void Remove(int code, int amount);

		int[][] List();

	}

}
namespace Manager.v1.Store
{
	public class Product
	{

		private int code;


		private int amount_Conflict;

		public Product(int code, int amount)
		{
			this.code = code;
			this.amount_Conflict = amount;
		}

		public virtual bool Exist(int amount)
		{
			return this.amount_Conflict >= amount;
		}

		public virtual void Add(int amount)
		{
			this.amount_Conflict += amount;
		}

		public virtual void Remove(int amount)
		{
			this.amount_Conflict -= amount;
		}

		public virtual int Amount()
		{
			return amount_Conflict;
		}

	}

}
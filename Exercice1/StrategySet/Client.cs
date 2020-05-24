namespace Strategy.Set
{
	public class Client
	{
		private void exec()
		{
			//The object context is reused by each strategy.
			// ...
			Context context = new Context();
			// ...
			context.Set(new ConcreteStrategyA());
			context.ContextInterface();
			// ...
			context.Set(new ConcreteStrategyB());
			context.ContextInterface();
			// ...
		}

		public static void Main(string[] args)
		{
			new Client().exec();
		}
	}
}

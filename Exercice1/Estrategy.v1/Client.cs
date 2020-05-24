namespace Estrategy.Constructor
{
	public class Client
	{
		/// <summary>
		/// The client a new object context by each strategy
		/// </summary>
		private void exec()
		{
			//This is similar to Template Methods.
			// ...
			Context context;
			// ...
			context = new Context(new ConcreteStrategyA());
			context.ContextInterface();
			// ...
			context = new Context(new ConcreteStrategyB());
			context.ContextInterface();
			// ...
		}

		public static void Main(string[] args)
		{
			new Client().exec();
		}
	}
}

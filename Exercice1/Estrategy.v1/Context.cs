using System;

namespace Estrategy.Constructor
{
	/// <summary>
	/// for each Strategy, we need create a new object context
	/// </summary>
	public class Context
	{
		private IStrategy strategy;

		public Context(IStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void ContextInterface()
		{
			Console.WriteLine("pre-strategy");
			strategy.AlgorithmInterface();
			Console.WriteLine("post-strategy");
		}
	}
}
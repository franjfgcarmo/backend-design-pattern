using System;

namespace Strategy.Set
{
	/// <summary>
	/// This form is more versatile, we can reuse the object context.
	/// </summary>
	public class Context
	{
		private IStrategy strategy;


		public void Set(IStrategy strategy)
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
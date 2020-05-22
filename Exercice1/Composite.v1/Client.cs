using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.v1
{
	public class Client
	{

		private void exec()
		{
			//...
			Leaf leaf1 = new Leaf();
			Leaf leaf2 = new Leaf();
			Composite composite1 = new Composite();
			composite1.Add(leaf1);
			composite1.Add(leaf2);
			Leaf leaf3 = new Leaf();
			Composite composite2 = new Composite();
			composite2.Add(leaf3);
			composite2.Add(composite1);
			//...
			IComponent component;
			//...
			component = leaf2;
			component.Operation();
			Console.WriteLine("------------------");
			//...
			component = composite2;
			component.Operation();
			//...
		}

		public static void Main(string[] args)
		{
			(new Client()).exec();
		}
	}

}

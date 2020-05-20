using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.v1
{
    public class Composite : IComponent
    {
		private List<IComponent> componentList;

		public Composite()
		{
			componentList = new List<IComponent>();
		}

		public void Operation()
		{
			Console.WriteLine("operation by Composite");
			foreach (IComponent component in componentList)
			{
				component.Operation();
			}
		}

		public virtual void Add(IComponent component)
		{
			componentList.Add(component);
		}

		public virtual void Remove(IComponent component)
		{
			componentList.Remove(component);
		}

	}
}

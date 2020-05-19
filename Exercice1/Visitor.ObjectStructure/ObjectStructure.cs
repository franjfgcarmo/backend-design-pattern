using System.Collections.Generic;

namespace _Visitor.ObjectStructure
{
	public class ObjectStructure
	{
		private List<IElement> elementList;

		public ObjectStructure()
		{
			elementList = new List<IElement>();
		}

		public virtual void Add(IElement element)
		{
			elementList.Add(element);
		}

		public virtual void Accept(IVisitor visitor)
		{
			foreach (var element in elementList)
			{
				element.Accept(visitor);
			}
		}


	}
}
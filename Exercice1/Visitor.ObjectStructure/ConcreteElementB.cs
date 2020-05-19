using System;

namespace _Visitor.ObjectStructure
{
	public class ConcreteElementB : IElement
	{
		public void Accept(IVisitor visitor)
		{
			visitor.visitConcreteElementB(this);
		}

	}
}
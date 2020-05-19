using System;

namespace _Visitor.ObjectStructure
{
	public class ConcreteElementA : IElement
	{
		public void Accept(IVisitor visitor)
		{
			visitor.visitConcreteElementA(this);
		}
	}
}
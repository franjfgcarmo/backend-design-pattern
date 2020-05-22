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
		/// <summary>
		/// Permite aceptar cualquier visitor, de esta forma se evita que esta clase crezca.
		/// </summary>
		/// <param name="visitor"></param>
		public virtual void Accept(IVisitor visitor)
		{
			foreach (var element in elementList)
			{
				element.Accept(visitor);
			}
		}


	}
}
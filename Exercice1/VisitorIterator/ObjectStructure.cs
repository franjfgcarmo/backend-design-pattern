﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.Iterator
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

		public virtual IEnumerator<IElement> Iterator()
		{
			return elementList.GetEnumerator();
		}

	}
}

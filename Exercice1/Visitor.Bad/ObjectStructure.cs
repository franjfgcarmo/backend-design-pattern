using System.Collections.Generic;

namespace _Visitor.Bad
{
    public class ObjectStructure
    {
        private List<IElement> elementList;

        public ObjectStructure()
        {
            elementList = new List<IElement>();
        }

        public virtual void add(IElement element)
        {
            elementList.Add(element);
        }

        public virtual void concreteA()
        {
            foreach (var element in elementList)
            {
                element.concreteA();
            }
        }

        public virtual void concreteB()
        {
            foreach (var element in elementList)
            {
                element.concreteB();
            }
        }

    }
}
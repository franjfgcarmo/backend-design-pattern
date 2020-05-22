using _Visitor.Iterator;
using System;

namespace _Visitor.Visitor
{
    public class ConcreteVisitorA : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("visitConcreteElementA by ConcreteVisitorA");
        }

        public void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("visitConcreteElementB by ConcreteVisitorA");
        }
        /// <summary>
        /// Aquí se podría a ver defino cómo se quiere visitar, número pares, cambiar order
        /// </summary>
        /// <param name="objectStructure"></param>
        public void VisitObjectStructure(ObjectStructure objectStructure)
        {
            foreach (var element in objectStructure.ElementList)
            {
                element.Accept(this);
            }
        }
    }
}

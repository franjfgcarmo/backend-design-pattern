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

        public void VisitObjectStructure(ObjectStructure objectStructure)
        {
            foreach (var element in objectStructure.ElementList)
            {
                element.Accept(this);
            }
        }
    }
}

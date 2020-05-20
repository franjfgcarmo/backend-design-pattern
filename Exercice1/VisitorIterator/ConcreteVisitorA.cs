using System;

namespace _Visitor.Iterator
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
    }
}

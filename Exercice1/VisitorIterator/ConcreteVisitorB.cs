using System;

namespace _Visitor.Iterator
{
    public class ConcreteVisitorB : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("visitConcreteElementA by ConcreteVisitorB");
        }

        public void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("visitConcreteElementB by ConcreteVisitorB");
        }
    }
}

using System;

namespace _Visitor.ObjectStructure
{
    public class ConcreteVisitorB : IVisitor
    {
        public void visitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("visitConcreteElementA by ConcreteVisitorB");
        }

        public void visitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("visitConcreteElementB by ConcreteVisitorB");
        }
    }
}

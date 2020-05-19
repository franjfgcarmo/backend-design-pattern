using System;

namespace _Visitor.ObjectStructure
{
    public class ConcreteVisitorA : IVisitor
    {
        public void visitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("visitConcreteElementA by ConcreteVisitorA");
        }

        public void visitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("visitConcreteElementB by ConcreteVisitorA");
        }
    }
}

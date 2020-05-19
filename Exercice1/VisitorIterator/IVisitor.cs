using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.Iterator
{
    public interface IVisitor
    {
        void visitConcreteElementA(ConcreteElementA concreteElementA);

        void visitConcreteElementB(ConcreteElementB concreteElementB);
    }
}

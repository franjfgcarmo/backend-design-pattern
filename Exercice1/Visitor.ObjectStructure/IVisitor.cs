using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.ObjectStructure
{
    public interface IVisitor
    {
        void visitConcreteElementA(ConcreteElementA concreteElementA);

        void visitConcreteElementB(ConcreteElementB concreteElementB);
    }
}

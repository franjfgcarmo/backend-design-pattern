using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.ObjectStructure
{
    public interface IVisitor
    {
        //es común que en las clase que implementan los visitor, tengan propiedades de acomulación que digan
        // es visto, este, este....
        void visitConcreteElementA(ConcreteElementA concreteElementA);

        void visitConcreteElementB(ConcreteElementB concreteElementB);
    }
}

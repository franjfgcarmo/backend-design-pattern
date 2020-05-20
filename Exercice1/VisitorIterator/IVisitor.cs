﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _Visitor.Iterator
{
    public interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA concreteElementA);

        void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}

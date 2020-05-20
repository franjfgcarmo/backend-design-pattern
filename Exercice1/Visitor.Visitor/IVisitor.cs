namespace _Visitor.Iterator
{
    public interface IVisitor
    {
        void VisitObjectStructure(ObjectStructure objectStructure);

        void VisitConcreteElementA(ConcreteElementA concreteElementA);

        void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}

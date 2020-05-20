namespace _Visitor.Iterator
{
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }
}
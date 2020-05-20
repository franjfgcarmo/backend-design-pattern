namespace _Visitor.Iterator
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

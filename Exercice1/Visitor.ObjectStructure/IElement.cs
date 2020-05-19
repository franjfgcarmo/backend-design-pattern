
namespace _Visitor.ObjectStructure
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

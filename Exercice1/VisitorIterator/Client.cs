using System.Collections.Generic;
namespace _Visitor.Iterator
{


    public class Client
    {

        private void Exec()
        {
            //...
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(new ConcreteElementA());
            objectStructure.Add(new ConcreteElementA());
            objectStructure.Add(new ConcreteElementB());
            objectStructure.Add(new ConcreteElementA());
            //...
            IEnumerator<IElement> elementIterator;

            ConcreteVisitorA concreteVisitorA = new ConcreteVisitorA();
            elementIterator = objectStructure.Iterator();
            while (elementIterator.MoveNext())
            {
                elementIterator.Current.Accept(concreteVisitorA);
            }
            //...
            ConcreteVisitorB concreteVisitorB = new ConcreteVisitorB();
            elementIterator = objectStructure.Iterator();
            while (elementIterator.MoveNext())
            {
                elementIterator.Current.Accept(concreteVisitorB);
            }
            //...


        }

        public static void Main(string[] args)
        {
            (new Client()).Exec();
        }

    }

}

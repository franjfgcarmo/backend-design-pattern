using System.Collections.Generic;
namespace _Visitor.Iterator
{


    public class Client
    {
        /// <summary>
        /// En este caso quien decide cómo visita es el cliente y el motivo para implantarlo así, es porque
        /// el cliente tiene el siguiente problema, es que no quiere que se realice cierta operación sobre
        /// todos los elementos de la estructura, sino sobre algunos
        /// </summary>
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

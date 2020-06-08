namespace FactoryMethod.v1
{
    public class ConcreteCreatorB : Creator
    {
        public ConcreteCreatorB()
        {
        }

        protected override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}
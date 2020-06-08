namespace FactoryMethod.v1
{
    public class ConcreteCreatorA : Creator
    {
        public ConcreteCreatorA()
        {
        }

        protected override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}
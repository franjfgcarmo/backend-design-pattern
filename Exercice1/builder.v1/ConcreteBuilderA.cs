namespace builder.v1
{
    public class ConcreteBuilderA : Builder
    {
        public override void BuilderPartA()
        {
            Product product = new ProductAA();
            product.Link(this.product);
            this.product = product;
        }

        public override void BuilderPartB()
        {
            Product product = new ProductAB();
            product.Link(this.product);
            this.product = product;
        }
    }
}
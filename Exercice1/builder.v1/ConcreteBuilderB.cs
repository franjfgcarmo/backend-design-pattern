namespace builder.v1
{
    public class ConcreteBuilderB: Builder
    {
        public override void BuilderPartA()
        {
            Product product = new ProductBA();
            if (this.product == null)
            {
                this.product = product;
            }
            else
            {
                Product actual = this.product;
                //while (actual.GetNextProduct() != null)
                //{
                //    actual = actual.GetNextProduct();
                //}
                actual.Link(this.product);
            }
        }

        public override void BuilderPartB()
        {
            Product product = new ProductBB();
            if (this.product == null)
            {
                this.product = product;
            }
            else
            {
                Product actual = this.product;
                //while (actual.GetNextProduct() != null)
                //{
                //    actual = actual.GetNextProduct();
                //}
                actual.Link(this.product);
            }
        }
    }
}
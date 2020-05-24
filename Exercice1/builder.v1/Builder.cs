namespace builder.v1
{
	public abstract class Builder
	{

		protected Product product;

		public abstract void BuilderPartA();

		public abstract void BuilderPartB();

		public Product GetResult() => product;
	}
}

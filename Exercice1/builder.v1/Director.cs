using System;

namespace builder.v1
{
    public class Director
    {
        private Builder builder;
        internal void Set(Builder builder)
        {
            this.builder = builder;
        }

        public Product Construct()
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
            builder.BuilderPartB();
            builder.BuilderPartA();
            builder.BuilderPartB();
            return builder.GetResult();
        }
    }
}
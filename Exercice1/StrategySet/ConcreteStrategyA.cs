using System;

namespace Strategy.Set
{
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("algorithmInterface por ConcreteStrategyA");
        }
    }
}
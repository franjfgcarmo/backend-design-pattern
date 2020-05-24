using System;

namespace Strategy.Set
{
    public class ConcreteStrategyB : IStrategy
    {

        public void AlgorithmInterface()
        {
            Console.WriteLine("algorithmInterface por ConcreteStrategyB");
        }
    }
}
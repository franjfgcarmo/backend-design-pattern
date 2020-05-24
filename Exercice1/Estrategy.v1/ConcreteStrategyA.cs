using System;

namespace Estrategy.Constructor
{
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("algorithmInterface por ConcreteStrategyA");
        }
    }
}
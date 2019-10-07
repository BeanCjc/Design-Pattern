using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------DediatorPattern--------------------");
            Console.WriteLine();
            Strategy strategyA = new ConcreteStrategyA();
            Strategy strategyB = new ConcreteStrategyB();
            Strategy strategyC = new ConcreteStrategyC();
            var context = new Context(strategyA);
            context.GetResult();
            context.Strategy = strategyB;
            context.GetResult();
            context.Strategy = strategyC;
            context.GetResult();

            Console.ReadKey();
        }
    }
}

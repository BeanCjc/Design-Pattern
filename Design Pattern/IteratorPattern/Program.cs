using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------CommandPattern--------------------");
            Console.WriteLine();
            IIterator iterator;
            var concreteAggregate = new ConcreteAggregate();
            iterator = concreteAggregate.CreateIterator();
            while (iterator.MoveNext())
            {
                var temp = iterator.GetCurrent().ToString();
                Console.WriteLine(temp);
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}

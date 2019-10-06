using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------TemplateMethodPattern--------------------");
            Console.WriteLine();

            AbstractClass abstractClass = new ConcreteClassA();
            abstractClass.EatDumplings();
            var abstractClass1 = new ConcreteClassB();
            abstractClass1.EatDumplings();
            Console.ReadKey();
        }
    }
}

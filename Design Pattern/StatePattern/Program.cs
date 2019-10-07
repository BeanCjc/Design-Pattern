using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------StatePattern--------------------");
            Console.WriteLine();
            var context = new Context();
            context.Minute = 10;
            context.Request();
            context.IsCancel = false;
            context.Request();
            context.Minute = 20;
            context.Request();
            context.Minute = 35;
            context.Request();
            context.Minute = 45;
            context.Request();

            Console.ReadKey();
        }
    }
}

using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------FacadePattern--------------------");
            Console.WriteLine();
            var facade = new SystemFacade();
            facade.Buy();
            Console.ReadKey();

        }
    }
}

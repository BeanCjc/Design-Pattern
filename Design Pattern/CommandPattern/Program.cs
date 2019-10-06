using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------CommandPattern--------------------");
            Console.WriteLine();
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker(command);

            //实际上请求者需要调用接收者的某些方法,而此处通过命令的形式将两者解耦
            invoker.GiveAnOrder();
            Console.ReadKey();
        }
    }
}

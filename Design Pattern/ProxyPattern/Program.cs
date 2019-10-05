using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------ProxyPattern--------------------");
            Console.WriteLine();
            AgentAbstract agent = new AgentPerson();
            agent.Speculation("搞点事情玩玩!");
            agent.Speculation("再搞点事情!");
            Console.ReadKey();
        }
    }
}

using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------DecoratorPattern--------------------");
            Console.WriteLine();

            //装修房子
            var house = new PatrickBeanHouse();
            house.Renovation();

            //增加安全系统
            var securityDecorator = new SecurityDecorator(house);
            securityDecorator.Renovation();

            //增加保暖功能
            var keepWarmDecorator = new KeepWarmDecorator(house);
            keepWarmDecorator.Renovation();


            Console.ReadLine();
        }
    }
}

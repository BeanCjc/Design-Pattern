using System;

namespace Prototypepattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------PrototypePattern--------------------");
            Console.WriteLine();
            var xingZheSun = new XingZheSunPrototype("行者孙爷爷");
            var xingZheSun1 = xingZheSun.Clone();
            var xingZheSun2 = xingZheSun.Clone();

            var sunXingZhe = new SunXingZhePrototype("孙行者爷爷");
            var sunXingZhe1 = sunXingZhe.Clone();
            var sunXingZhe2 = sunXingZhe1.Clone();

            xingZheSun.Fight();
            xingZheSun1.Fight();
            xingZheSun2.Fight();

            Console.WriteLine();
            sunXingZhe.BegAlms();
            sunXingZhe1.BegAlms();
            sunXingZhe2.BegAlms();

            Console.ReadLine();
        }
    }
}

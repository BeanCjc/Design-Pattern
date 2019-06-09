using AdapterPattern.ClassAdapter;
using AdapterPattern.ObjectAdapter;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------AdapterPattern--------------------");
            Console.WriteLine();

            //对象适配器
            TwoHoleSocketTarket twoHoleSocket = new ThreeToTwoAdatpter();
            twoHoleSocket.Request();

            Console.WriteLine("------------------------------------------------------");

            //类适配器
            ITwoHoleSocketTarket twoHoleSocketInterface = new ThreeToTwoAdapter();
            twoHoleSocketInterface.Request();
            Console.WriteLine("------------------------------------------------------");

            Console.ReadLine();
        }
    }
}

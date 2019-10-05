using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------FlyWeightPattern--------------------");
            Console.WriteLine();
            var factory = new SoldierFactory();
            var ak47 = new AK47();
            for (int i = 0; i < 10000; i++)
            {
                Soldier soldier = null;
                if (i<5000)
                {
                    soldier=factory.GetSoldier($"士兵A", ak47, SoldierType.Normal);
                }
                else
                {
                    soldier=factory.GetSoldier($"士兵B", ak47, SoldierType.Water);
                }
                soldier.Fight();
            }
            Console.WriteLine("complete!");
            Console.ReadKey();
        }
    }
}

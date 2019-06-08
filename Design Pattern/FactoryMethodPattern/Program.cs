using FactoryMethodPattern.FactoryMethod;
using FactoryMethodPattern.SingleFactory;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------FactoryMethodPattern--------------------");
            Console.WriteLine("");

            #region 简单工厂
            var food1 = FoodSimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();
            var food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food2.Print();
            #endregion

            #region 工厂方法
            //客户端调用

            //初始化红旗汽车工厂
            var hongQiCarFactory = new HongQiCarFactory();
            //生产宏碁汽车
            var hongQiCar = hongQiCarFactory.CreateCar();
            hongQiCar.Go();

            var aoDiCarFactory = new AoDiCarFactory();
            var aoDiCar = aoDiCarFactory.CreateCar();
            aoDiCar.Go();

            var benChiCarFactory = new BenChiCarFactory();
            var benChiCar = benChiCarFactory.CreateCar();
            benChiCar.Go();
            #endregion

            Console.ReadLine();
        }
    }
}

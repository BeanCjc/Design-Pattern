using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------AbstractFactoryPattern--------------------");
            Console.WriteLine("");

            //初始化红旗汽车工厂
            var hongQiCarFactory = new HongQiCarFactory.HongQiCarFactory();
            Console.WriteLine("创建红旗汽车");
            //创建红旗汽车引擎
            hongQiCarFactory.CreateEngine().Create();
            //创建红旗汽车底盘
            hongQiCarFactory.CreateChassis().Create();
            //创建红旗汽车车身
            hongQiCarFactory.CreateBodyWork().Create();
            //创建红旗汽车电气设备
            hongQiCarFactory.CreateElectricalEquipment().Create();
            Console.WriteLine("---------------------------------------------------------------");


            //初始化奥迪汽车工厂
            var aoDiCarFactory = new AoDiCarFactory.AoDiCarFactory();
            Console.WriteLine("创建奥迪汽车");
            aoDiCarFactory.CreateEngine().Create();
            aoDiCarFactory.CreateChassis().Create();
            aoDiCarFactory.CreateBodyWork().Create();
            aoDiCarFactory.CreateElectricalEquipment().Create();
            Console.WriteLine("---------------------------------------------------------------");

            //初始化自定义汽车工厂
            var customCarFactory = new CustomCarFactory.CustomCarFactory();
            Console.WriteLine("创建自定义汽车");
            customCarFactory.CreateEngine().Create();
            customCarFactory.CreateChassis().Create();
            customCarFactory.CreateBodyWork().Create();
            customCarFactory.CreateElectricalEquipment().Create();
            Console.WriteLine("---------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}

using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------BuilderPattern--------------------");
            Console.WriteLine();

            //指导者
            var director = new Director();

            //红旗汽车组装者
            var hongQiBuilder = new HongQIBuilder();
            //组装红旗汽车
            director.Construct(hongQiBuilder);
            //从红旗汽车组装者那里获得红旗汽车
            var hongQiCar = hongQiBuilder.GetCar();
            //显示红旗汽车
            hongQiCar.Show();
            Console.WriteLine("------------------------------------------------------");


            var aoDiBuilder = new AoDiBuilder();
            director.Construct(aoDiBuilder);
            var aoDiCar = aoDiBuilder.GetCar();
            aoDiCar.Show();
            Console.WriteLine("------------------------------------------------------");

            Console.ReadLine();

        }
    }
}

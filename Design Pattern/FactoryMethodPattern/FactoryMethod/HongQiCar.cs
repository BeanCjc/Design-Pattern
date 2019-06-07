using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class HongQiCar : Car
    {
        public override void Go() => Console.WriteLine("红旗汽车开始行驶了");
    }
}

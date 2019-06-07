using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class BenChiCar : Car
    {
        public override void Go() => Console.WriteLine("奔驰汽车开始行驶了");

    }
}

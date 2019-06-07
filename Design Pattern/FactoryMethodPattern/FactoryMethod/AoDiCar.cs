using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class AoDiCar : Car
    {
        public override void Go() => Console.WriteLine("奥迪汽车开始行驶了");
    }
}

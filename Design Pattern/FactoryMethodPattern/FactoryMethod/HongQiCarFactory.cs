using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class HongQiCarFactory : Factory
    {
        public override Car CreateCar() => new HongQiCar();
    }
}

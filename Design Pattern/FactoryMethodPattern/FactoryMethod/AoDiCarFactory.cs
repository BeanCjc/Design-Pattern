using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class AoDiCarFactory : Factory
    {
        public override Car CreateCar() => new AoDiCar();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public class BenChiCarFactory : Factory
    {
        public override Car CreateCar() => new BenChiCar();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    public abstract class Factory
    {
        public abstract Car CreateCar();
    }
}

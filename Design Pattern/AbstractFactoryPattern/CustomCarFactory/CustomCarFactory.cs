using AbstractFactoryPattern.AbstractClass;
using AbstractFactoryPattern.CustomComposition;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.CustomCarFactory
{
    public class CustomCarFactory : AbstractFactory
    {
        public override Bodywork CreateBodyWork() => new CustomBodywork();

        public override Chassis CreateChassis() => new CustomChassis();

        public override ElectricalEquipment CreateElectricalEquipment() => new CustomElectricalEquipment();

        public override Engine CreateEngine() => new CustomEngine();
    }
}

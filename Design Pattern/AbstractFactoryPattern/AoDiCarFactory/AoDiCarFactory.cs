using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.AoDiComposition;

namespace AbstractFactoryPattern.AoDiCarFactory
{
    /// <summary>
    /// 奥迪汽车工厂类
    /// </summary>
    public class AoDiCarFactory : AbstractFactory
    {
        public override Bodywork CreateBodyWork() => new AoDiBodywork();

        public override Chassis CreateChassis() => new AoDiChassis();

        public override ElectricalEquipment CreateElectricalEquipment() => new AoDiElectricalEquipment();

        public override Engine CreateEngine() => new AoDiEngine();
    }
}

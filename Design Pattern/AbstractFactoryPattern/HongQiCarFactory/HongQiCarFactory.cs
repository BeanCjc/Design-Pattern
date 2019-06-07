using AbstractFactoryPattern.AbstractClass;
using AbstractFactoryPattern.HongQiComposition;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HongQiCarFactory
{
    /// <summary>
    /// 红旗汽车工厂类
    /// </summary>
    public class HongQiCarFactory : AbstractFactory
    {
        public override Bodywork CreateBodyWork() => new HongQiBodywork();

        public override Chassis CreateChassis() => new HongQiChassis();

        public override ElectricalEquipment CreateElectricalEquipment() => new HongQiElectricalEquipment();

        public override Engine CreateEngine() => new HongQiEngine();
    }
}

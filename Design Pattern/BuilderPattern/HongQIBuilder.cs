using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 红旗汽车创造者
    /// </summary>
    public sealed class HongQIBuilder : Builder
    {
        /// <summary>
        /// 汽车是通过建造者new出来的,私有的
        /// </summary>
        Car hongQiCar = new Car();
        public override void BuildBodywork() => hongQiCar.Add("HongQiBodywork");

        public override void BuildChassis() => hongQiCar.Add("HongQiChassis");

        public override void BuildElectricalEquipment() => hongQiCar.Add("HongQiElectricalEquipment");

        public override void BuildEngine() => hongQiCar.Add("HongQiEngine");

        public override Car GetCar() => hongQiCar;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 奥迪汽车创造者
    /// </summary>
    public sealed class AoDiBuilder : Builder
    {
        /// <summary>
        /// 汽车是通过建造者new出来的,私有的
        /// </summary>
        Car aoDiCar = new Car();
        public override void BuildBodywork() => aoDiCar.Add("AoDiBodywork");

        public override void BuildChassis() => aoDiCar.Add("AoDiChassis");

        public override void BuildElectricalEquipment() => aoDiCar.Add("AoDiElectricalEquipment");

        public override void BuildEngine() => aoDiCar.Add("AoDiEngine");

        public override Car GetCar() => aoDiCar;
    }
}

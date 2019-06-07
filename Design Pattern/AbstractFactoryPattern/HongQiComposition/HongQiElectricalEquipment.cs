using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HongQiComposition
{
    /// <summary>
    /// 红旗电气设备类
    /// </summary>
    public class HongQiElectricalEquipment : ElectricalEquipment
    {
        public override void Create() => Console.WriteLine("红旗电气设备已创建");
    }
}

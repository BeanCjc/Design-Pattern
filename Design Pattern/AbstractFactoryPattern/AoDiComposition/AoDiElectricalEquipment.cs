using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AoDiComposition
{
    /// <summary>
    /// 奥迪电气设备类
    /// </summary>
    public class AoDiElectricalEquipment : ElectricalEquipment
    {
        public override void Create() => Console.WriteLine("奥迪电气设备已创建");
    }
}

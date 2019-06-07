using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.CustomComposition
{
    /// <summary>
    /// 自定义电气设备--奥迪电气设备类
    /// </summary>
    public class CustomElectricalEquipment : ElectricalEquipment
    {
        public override void Create() => Console.WriteLine("自定义电气设备--奥迪电气设备已创建");
    }
}

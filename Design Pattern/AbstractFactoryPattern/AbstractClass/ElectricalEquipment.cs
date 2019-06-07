using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClass
{
    /// <summary>
    /// 汽车电气设备抽象类
    /// </summary>
    public abstract class ElectricalEquipment
    {
        /// <summary>
        /// 汽车电气设备创建抽象方法
        /// </summary>
        public abstract void Create();
    }
}

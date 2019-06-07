using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClass
{
    /// <summary>
    /// 汽车工厂抽象类
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 创建汽车引擎抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract Engine CreateEngine();

        /// <summary>
        /// 创建汽车底盘抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract Chassis CreateChassis();

        /// <summary>
        /// 创建汽车车身抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract Bodywork CreateBodyWork();

        /// <summary>
        /// 创建汽车电气设备抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract ElectricalEquipment CreateElectricalEquipment();
    }
}

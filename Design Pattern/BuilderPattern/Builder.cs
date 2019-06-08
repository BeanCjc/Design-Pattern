using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 抽象建造者类,它定义了要创建什么部件和最后创建的结果,但不是组装的类型
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 创建引擎
        /// </summary>
        public abstract void BuildEngine();

        /// <summary>
        /// 创建底盘
        /// </summary>
        public abstract void BuildChassis();

        /// <summary>
        /// 创建车身
        /// </summary>
        public abstract void BuildBodywork();

        /// <summary>
        /// 创建电气设备
        /// </summary>
        public abstract void BuildElectricalEquipment();

        /// <summary>
        /// 获得组装好的汽车
        /// </summary>
        /// <returns></returns>
        public abstract Car GetCar();
    }
}

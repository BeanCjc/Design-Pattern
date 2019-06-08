using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 指导者,指挥者类.Construct方法的实现就是创建复杂对象固定算法的实现,该算法是固定的,或者说是相对稳定的
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 组装汽车的通用抽象方法
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildEngine();
            builder.BuildChassis();
            builder.BuildBodywork();
            builder.BuildElectricalEquipment();
        }
    }
}

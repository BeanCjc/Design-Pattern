using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClass
{
    /// <summary>
    /// 汽车底盘抽象类
    /// </summary>
    public abstract class Chassis
    {
        /// <summary>
        /// 汽车底盘创建抽象方法
        /// </summary>
        public abstract void Create();
    }
}

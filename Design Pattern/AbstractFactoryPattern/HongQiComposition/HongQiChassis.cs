using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HongQiComposition
{
    /// <summary>
    /// 红旗底盘类
    /// </summary>
    public class HongQiChassis : Chassis
    {
        public override void Create() => Console.WriteLine("红旗底盘已创建");
    }
}

using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.CustomComposition
{
    /// <summary>
    /// 自定义底盘--红旗底盘类
    /// </summary>
    public class CustomChassis : Chassis
    {
        public override void Create() => Console.WriteLine("自定义底盘--红旗底盘已创建");
    }
}

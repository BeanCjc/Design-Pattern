using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AoDiComposition
{
    /// <summary>
    /// 奥迪底盘类
    /// </summary>
    public class AoDiChassis : Chassis
    {
        public override void Create() => Console.WriteLine("奥迪底盘已创建");
    }
}

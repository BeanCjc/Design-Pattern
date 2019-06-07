using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AoDiComposition
{
    /// <summary>
    /// 奥迪车身类
    /// </summary>
    public class AoDiBodywork : Bodywork
    {
        public override void Create() => Console.WriteLine("奥迪车身已创建");
    }
}

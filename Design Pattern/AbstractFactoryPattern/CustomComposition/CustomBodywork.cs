using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.CustomComposition
{
    /// <summary>
    /// 自定义车身--奥迪车身类
    /// </summary>
    public class CustomBodywork : Bodywork
    {
        public override void Create() => Console.WriteLine("自定义车身--奥迪车身已创建");
    }
}

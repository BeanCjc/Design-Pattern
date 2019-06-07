using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.CustomComposition
{
    /// <summary>
    /// 自定义引擎--红旗引擎类
    /// </summary>
    public class CustomEngine : Engine
    {
        public override void Create() => Console.WriteLine("自定义引擎--红旗引擎已创建");
    }
}

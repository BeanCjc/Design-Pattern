using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AoDiComposition
{
    /// <summary>
    /// 奥迪引擎类
    /// </summary>
    public class AoDiEngine : Engine
    {
        public override void Create() => Console.WriteLine("奥迪引擎已创建");
    }
}

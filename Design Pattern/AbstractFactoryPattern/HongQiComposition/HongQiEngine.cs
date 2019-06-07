using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HongQiComposition
{
    /// <summary>
    /// 红旗引擎类
    /// </summary>
    public class HongQiEngine : Engine
    {
        public override void Create() => Console.WriteLine("红旗引擎已创建");
    }
}

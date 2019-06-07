using AbstractFactoryPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HongQiComposition
{
    /// <summary>
    /// 红旗车身类
    /// </summary>
    public class HongQiBodywork : Bodywork
    {
        public override void Create() => Console.WriteLine("红旗车身已创建");
    }
}

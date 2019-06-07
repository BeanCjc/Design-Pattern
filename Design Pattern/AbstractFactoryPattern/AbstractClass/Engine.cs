using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClass
{

    /// <summary>
    /// 汽车引擎抽象类
    /// </summary>
    public abstract class Engine
    {
        /// <summary>
        /// 汽车引擎创建抽象方法
        /// </summary>
        public abstract void Create();
    }
}

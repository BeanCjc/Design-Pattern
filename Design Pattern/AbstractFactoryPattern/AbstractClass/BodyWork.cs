using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClass
{
    /// <summary>
    /// 汽车车身抽象类
    /// </summary>
    public abstract class Bodywork
    {
        /// <summary>
        /// 汽车车身创建抽象方法
        /// </summary>
        public abstract void Create();
    }
}

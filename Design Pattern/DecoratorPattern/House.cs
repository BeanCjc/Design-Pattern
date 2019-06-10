using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 房子抽象类,需要装饰的类,抽象构建角色
    /// </summary>
    public abstract class House
    {
        /// <summary>
        /// 装饰的方法
        /// </summary>
        public abstract void Renovation();
    }
}

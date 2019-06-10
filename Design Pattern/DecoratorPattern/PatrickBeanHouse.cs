using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体构建角色
    /// </summary>
    public sealed class PatrickBeanHouse : House
    {
        public override void Renovation()
        {
            Console.WriteLine("装修Bean的房子");
        }
    }
}

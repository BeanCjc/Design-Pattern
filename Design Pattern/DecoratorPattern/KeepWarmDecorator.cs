using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 额外的装饰类,具体装饰角色
    /// </summary>
    public sealed class KeepWarmDecorator : DecorationStrategy
    {
        public KeepWarmDecorator(House house) : base(house) { }
        public override void Renovation()
        {
            Console.WriteLine("增加保暖功能");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 额外的装饰类,具体装饰角色
    /// </summary>
    public sealed class SecurityDecorator : DecorationStrategy
    {
        public SecurityDecorator(House house) : base(house) { }
        public override void Renovation()
        {
            Console.WriteLine("增加安全系统");
        }
    }
}

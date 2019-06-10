using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 装饰接口的定,装饰角色
    /// </summary>
    public abstract class DecorationStrategy:House
    {
        //包含关系
        protected House _house;
        /// <summary>
        /// 构造器注入
        /// </summary>
        /// <param name="house"></param>
        public DecorationStrategy(House house)
        {
            _house = house;
        }
        public override void Renovation()
        {
            _house.Renovation();
        }

    }
}

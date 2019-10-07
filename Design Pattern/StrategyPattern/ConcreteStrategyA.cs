using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 具体策略角色
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        /// <summary>
        /// 实现算法的具体实现
        /// </summary>
        public void Algorithm()
        {
            Console.WriteLine("我是算法A的计算方式");
        }
    }
}

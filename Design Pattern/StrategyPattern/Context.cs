using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 环境角色类
    /// </summary>
    public class Context
    {
        public Strategy Strategy { get; set; }
        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }

        /// <summary>
        /// 根据不同的ConcreteStrategy调用不同的算法
        /// </summary>
        public void GetResult()
        {
            Strategy.Algorithm();
        }
    }
}

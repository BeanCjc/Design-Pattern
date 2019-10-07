using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 抽象策略角色
    /// </summary>
    public interface Strategy
    {
        /// <summary>
        /// 定义算法
        /// </summary>
        void Algorithm();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 定义抽象聚合接口
    /// </summary>
    public interface Aggregate
    {
        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        IIterator CreateIterator();
    }
}

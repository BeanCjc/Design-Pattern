using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 定义迭代器抽象接口
    /// </summary>
    public interface IIterator
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }
}

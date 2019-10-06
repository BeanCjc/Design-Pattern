using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 具体迭代器角色,实现迭代器接口里的方法
    /// </summary>
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggregate ConcreteAggregate;
        private int Index;
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            ConcreteAggregate = concreteAggregate;
            Index = 0;
        }
        public object GetCurrent()
        {
            return ConcreteAggregate.GetElement(Index);
        }

        public bool MoveNext()
        {
            if (Index < ConcreteAggregate.Length)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if (Index < ConcreteAggregate.Length)
            {
                Index++;
            }
        }

        public void Reset()
        {
            Index = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private string[] collection;
        public ConcreteAggregate()
        {
            collection = new string[] { "张三", "李四", "王五" };
        }

        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// 具体聚合类的一些属性,长度
        /// </summary>
        public int Length
        {
            get { return collection.Length; }
        }

        /// <summary>
        /// 具体聚合类的一些方法,获取当前值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetElement(int index)
        {
            return collection[index];
        }
    }
}

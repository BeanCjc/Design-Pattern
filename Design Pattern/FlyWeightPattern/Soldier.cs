using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{

    /// <summary>
    /// 抽象战士
    /// </summary>
    public abstract class Soldier
    {
        /// <summary>
        /// 外部状态
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 通过构造函数初始士兵的名称,将外部状态传到内部
        /// </summary>
        /// <param name="name"></param>
        protected Soldier(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 士兵作战
        /// </summary>
        public abstract void Fight();
        public Weapen WeapenInstance { get; set; }
    }
}

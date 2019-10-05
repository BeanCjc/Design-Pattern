using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// 一般类型的战士,实现Soldier的类
    /// </summary>
    public sealed class NormalSoldier : Soldier
    {
        /// <summary>
        /// 通过构造函数初始士兵的名称
        /// </summary>
        /// <param name="name"></param>
        public NormalSoldier(string name) : base(name) { }

        /// <summary>
        /// 执行享元方法
        /// </summary>
        public override void Fight()
        {
            WeapenInstance.Fire($"士兵:{Name}在陆地执行击毙任务!");
        }
    }
}

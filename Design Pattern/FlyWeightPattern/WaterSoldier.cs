using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// 海军战士,实现Soldier类
    /// </summary>
    public sealed class WaterSoldier : Soldier
    {
        public WaterSoldier(string name) : base(name) { }

        /// <summary>
        /// 执行享元方法
        /// </summary>
        public override void Fight()
        {
            WeapenInstance.Fire($"士兵:{Name}在海中执行击毙任务!");
        }
    }
}

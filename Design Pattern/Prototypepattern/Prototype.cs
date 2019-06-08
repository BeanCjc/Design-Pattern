using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypepattern
{
    /// <summary>
    /// 抽象原型,定义了原型本身具有的特征和行为
    /// </summary>
   public abstract class Prototype
    {
        /// <summary>
        /// 属性--姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 行为--战斗
        /// </summary>
        public abstract void Fight();

        /// <summary>
        /// 行为--乞讨
        /// </summary>
        public abstract void BegAlms();

        /// <summary>
        /// 行为--克隆自身
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
}

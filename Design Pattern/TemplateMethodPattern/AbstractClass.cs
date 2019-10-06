using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 抽象角色类,定义算法的骨架和步骤
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 模板方法,具有固定算法的方法
        /// </summary>
        public void EatDumplings()
        {
            MakingDough();
            MakingDumplings();
            BoiledDumplings();
        }

        /// <summary>
        /// 算法中的一步,也可以用virtual来给予默认实现
        /// </summary>
        protected abstract void MakingDough();

        /// <summary>
        /// 算法中的一步,也可以用virtual来给予默认实现
        /// </summary>
        protected abstract void MakingDumplings();

        /// <summary>
        /// 算法中的一步,也可以用virtual来给予默认实现
        /// </summary>
        protected abstract void BoiledDumplings();
    }
}

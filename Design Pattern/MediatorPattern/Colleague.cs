using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象同事类Colleague
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// 有中介者的引用,同事类间的交互转换为同事类和中介者之间的交互
        /// </summary>
        protected Mediator Mediator;
        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Apply();
        public abstract void Process();
    }
}

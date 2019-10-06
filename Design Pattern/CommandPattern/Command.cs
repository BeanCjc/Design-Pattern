using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// 命令接收者
        /// </summary>
        protected Receiver Receiver;
        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        /// <summary>
        /// 命令的执行
        /// </summary>
        public abstract void Execute();
    }
}

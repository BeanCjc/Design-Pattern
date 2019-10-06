using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 请求者角色,也就是命令下达者
    /// </summary>
    public class Invoker
    {
        private Command Command;
        public Invoker(Command command)
        {
            Command = command;
        }

        /// <summary>
        /// 请求者下达命令
        /// </summary>
        public void GiveAnOrder()
        {
            Command.Execute();
        }
    }
}

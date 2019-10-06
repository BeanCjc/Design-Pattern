using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 具体的命令角色
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }
        public override void Execute()
        {
            Receiver.DoSomething("开始执行命令...");
        }
    }
}

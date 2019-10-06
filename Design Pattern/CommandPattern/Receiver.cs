using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 命令接收者,也就是命令具体的执行者
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// action
        /// </summary>
        /// <param name="job"></param>
        public void DoSomething(string job)
        {
            Console.WriteLine(job);
        }
    }
}

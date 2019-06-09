using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// SqlServer2008数据库针对Unix的具体实现
    /// </summary>
    public class SqlServer2008UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2008针对Unix的具体实现");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// SqlServer2017数据库针对Unix的具体实现
    /// </summary>
    public class SqlServer2017UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2017针对Unix的具体实现");
        }
    }
}

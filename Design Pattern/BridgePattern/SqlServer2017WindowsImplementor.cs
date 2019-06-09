using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class SqlServer2017WindowsImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2017针对Windows的具体实现");
        }
    }
}

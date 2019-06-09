using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class SqlServer2008WindowsImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2008针对Windows的具体实现");
        }
    }
}

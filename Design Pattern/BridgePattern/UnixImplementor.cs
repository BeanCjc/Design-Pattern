using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("Unix平台");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class WindowsImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("Windows平台");
        }
    }
}

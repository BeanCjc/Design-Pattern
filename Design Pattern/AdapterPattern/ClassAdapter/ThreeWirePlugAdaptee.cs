using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// 三线插头,需要适配的类
    /// </summary>
   public abstract class ThreeWirePlugAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是三线插头哟");
        }
    }
}

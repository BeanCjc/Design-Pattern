using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SingleFactory
{
    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }
}

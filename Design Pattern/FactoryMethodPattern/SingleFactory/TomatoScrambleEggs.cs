using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SingleFactory
{
    /// <summary>
    /// 西红柿炒蛋这道菜
    /// </summary>
    public class TomatoScrambleEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋");
        }
    }
}

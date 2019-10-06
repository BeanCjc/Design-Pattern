using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 具体角色类,橙色面皮韭菜馅儿的,用红糖水煮出来的饺子
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        protected override void BoiledDumplings()
        {
            Console.WriteLine("这是用红糖水煮出来的饺子");
        }

        protected override void MakingDough()
        {
            Console.WriteLine("这是橙色面皮的饺子");
        }

        protected override void MakingDumplings()
        {
            Console.WriteLine("这是韭菜馅儿的饺子");
        }
    }
}

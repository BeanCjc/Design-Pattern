using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 具体角色类,绿色面皮猪肉大葱馅儿用山泉水煮的饺子
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        protected override void BoiledDumplings()
        {
            Console.WriteLine("这是山泉水煮出来的饺子");
        }

        protected override void MakingDough()
        {
            Console.WriteLine("这是绿色面皮的饺子皮");
        }

        protected override void MakingDumplings()
        {
            Console.WriteLine("这是猪肉大葱馅儿的饺子");
        }
    }
}

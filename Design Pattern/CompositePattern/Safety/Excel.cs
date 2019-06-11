using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Safety
{
    public sealed class Excel : Folder
    {
        public override void Open()
        {
            Console.WriteLine("打开Excel文件,开始编辑");
        }
    }
}

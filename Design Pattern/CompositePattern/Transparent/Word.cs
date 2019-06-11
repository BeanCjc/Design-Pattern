using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Transparent
{
    public sealed class Word : Folder
    {
        public override void Add(Folder folder)
        {
            //throw new NotImplementedException("Word文档不具有该功能");
            Console.WriteLine("Word文档不具有该功能----------");
        }

        public override void Open()
        {
            Console.WriteLine("打开Word文档,开始编辑");
        }

        public override void Remove(Folder folder)
        {
            //throw new NotImplementedException("Word文档不具有该功能");
            Console.WriteLine("Word文档不具有该功能----------");
        }
    }
}

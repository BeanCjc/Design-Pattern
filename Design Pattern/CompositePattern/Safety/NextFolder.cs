using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Safety
{
    public sealed class NextFolder : SonFolder
    {
        public override void Add(Folder folder)
        {
            Console.WriteLine("文件或文件夹添加成功.");
        }

        public override void Remove(Folder folder)
        {
            Console.WriteLine("文件或文件夹删除成功.");
        }
    }
}

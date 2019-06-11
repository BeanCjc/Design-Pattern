using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Transparent
{
    public class SonFolder : Folder
    {
        public override void Add(Folder folder)
        {
            Console.WriteLine("文件或文件夹已经添加成功");
        }

        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }

        public override void Remove(Folder folder)
        {
            Console.WriteLine("文件或文件夹已删除成功");
        }
    }
}

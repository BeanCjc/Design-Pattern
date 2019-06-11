using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Safety
{
    public abstract class SonFolder : Folder
    {
        public abstract void Add(Folder folder);
        public abstract void Remove(Folder folder);
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹.");
        }
    }
}

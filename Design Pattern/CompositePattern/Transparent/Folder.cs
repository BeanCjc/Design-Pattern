using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Transparent
{
    
    public abstract class Folder
    {
        public abstract void Open();
        public abstract void Add(Folder folder);
        public abstract void Remove(Folder folder);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public abstract class GoodsElement
    {
        public int Size { get; set; }
        public string State { get; set; }
        public abstract void Operate(Visitor visitor);
    }
}

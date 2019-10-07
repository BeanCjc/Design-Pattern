using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public class TelevisionConcreteElement : GoodsElement
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutTelevision(this);
        }
    }
}

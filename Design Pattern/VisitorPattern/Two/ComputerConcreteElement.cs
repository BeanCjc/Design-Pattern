using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public class ComputerConcreteElement : GoodsElement
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutComputer(this);
        }
    }
}

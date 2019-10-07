using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public abstract class Visitor
    {
        public abstract void PutTelevision(TelevisionConcreteElement television);
        public abstract void PutComputer(ComputerConcreteElement computer);
    }
}

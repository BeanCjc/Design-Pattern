using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public class StateConcreteVisitor : Visitor
    {
        public override void PutComputer(ComputerConcreteElement computer)
        {
            Console.WriteLine($"按商品新旧值{computer.State}排放");
        }

        public override void PutTelevision(TelevisionConcreteElement television)
        {
            Console.WriteLine($"按商品新旧值{television.State}排放");
        }
    }
}

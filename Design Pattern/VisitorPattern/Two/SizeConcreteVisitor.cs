using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public class SizeConcreteVisitor : Visitor
    {
        public override void PutComputer(ComputerConcreteElement computer)
        {
            Console.WriteLine($"按商品大小{computer.Size}排放");
        }

        public override void PutTelevision(TelevisionConcreteElement television)
        {
            Console.WriteLine($"按商品大小{television.Size}排放");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.One
{
    public class CustomConcreteVisitor : ShapeVisitor
    {
        public override void Visit(RectangleConcreteElement shapeElement)
        {
            Console.WriteLine("针对Rectangle新的操作!");
        }

        public override void Visit(CircleConcreteElement shapeElement)
        {
            Console.WriteLine("针对Circle新的操作!");
        }

        public override void Visit(LineConcreteElement shapeElement)
        {
            Console.WriteLine("针对Line新的操作!");
        }
    }
}

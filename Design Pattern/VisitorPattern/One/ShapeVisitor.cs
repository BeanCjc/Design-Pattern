using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.One
{
    public abstract class ShapeVisitor
    {
        public abstract void Visit(RectangleConcreteElement shapeElement);
        public abstract void Visit(CircleConcreteElement shapeElement);
        public abstract void Visit(LineConcreteElement shapeElement);
    }
}

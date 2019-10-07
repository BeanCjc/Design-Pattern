using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.One
{
    /// <summary>
    /// 直线,具体节点角色
    /// </summary>
    public class LineConcreteElement : ShapeElement
    {
        public override void Accept(ShapeVisitor shapeVisitor)
        {
            shapeVisitor.Visit(this);
        }

        public override void Draw()
        {
            Console.WriteLine("已画好直线!");
        }
    }
}

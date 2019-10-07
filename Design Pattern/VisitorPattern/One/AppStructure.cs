using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.One
{
    /// <summary>
    /// 结构对象角色
    /// </summary>
    public class AppStructure
    {
        ShapeVisitor ShapeVisitor;
        public AppStructure(ShapeVisitor shapeVisitor)
        {
            ShapeVisitor = shapeVisitor;
        }

        public void Process(ShapeElement shapeElement)
        {
            shapeElement.Accept(ShapeVisitor);
        }
    }
}

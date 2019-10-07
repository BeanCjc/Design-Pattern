using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.One
{
    /// <summary>
    /// 抽象提醒定义,抽象节点角色
    /// </summary>
    public abstract class ShapeElement
    {
        /// <summary>
        /// 画图形
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// 外界注入具体访问者
        /// </summary>
        /// <param name="shapeVisitor"></param>
        public abstract void Accept(ShapeVisitor shapeVisitor);
    }
}

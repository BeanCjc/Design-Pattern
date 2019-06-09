using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ObjectAdapter
{
    /// <summary>
    /// 两孔插座,目标角色.可写成抽象类或接口
    /// </summary>
    public class TwoHoleSocketTarket
    {
        /// <summary>
        /// 客户端需要的方法
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("两孔的充电器可以使用");
        }
    }
}

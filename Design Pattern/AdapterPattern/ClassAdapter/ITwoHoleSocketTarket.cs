using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// 两孔插座,目标角色
    /// </summary>
   public interface ITwoHoleSocketTarket
    {
        void Request();
    }
}

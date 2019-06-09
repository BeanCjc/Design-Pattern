using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// 适配器类,由于是继承关系,而类只能继承一个也就是说只能适配一个对象
    /// </summary>
    public class ThreeToTwoAdapter : ThreeWirePlugAdaptee, ITwoHoleSocketTarket
    {
        /// <summary>
        /// 实现两线插头方法
        /// </summary>
        public void Request()
        {
            //调用三线插头方法
            SpecificRequest();
        }
    }
}

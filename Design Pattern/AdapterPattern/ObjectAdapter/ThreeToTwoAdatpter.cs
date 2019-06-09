using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.ObjectAdapter
{
    /// <summary>
    /// 适配器类
    /// </summary>
    public class ThreeToTwoAdatpter : TwoHoleSocketTarket
    {
        private ThreeWirePlugAdaptee ThreeWirePlugAdaptee = new ThreeWirePlugAdaptee();

        /// <summary>
        /// 实现两线插头方法
        /// </summary>
        public override void Request()
        {
            //转换工作
            ThreeWirePlugAdaptee.SpecificRequest();
        }
    }
}

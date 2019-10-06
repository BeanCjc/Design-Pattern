using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象中介者Mediator
    /// </summary>
    public interface Mediator
    {
        /// <summary>
        /// 处理各个同事类间的方法
        /// </summary>
        /// <param name="colleague"></param>
        void Command(Colleague colleague);
    }
}

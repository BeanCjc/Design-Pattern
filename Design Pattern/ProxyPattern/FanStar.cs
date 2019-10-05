using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 真实的对象
    /// </summary>
    public class FanStar:AgentAbstract
    {
        public override void Speculation(string something)
        {

            base.Speculation(something);
        }
    }
}

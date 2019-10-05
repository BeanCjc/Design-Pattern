using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 代理类,包含了真实对象FanStar
    /// </summary>
    public class AgentPerson:AgentAbstract
    {
        private FanStar FanStar;
        public AgentPerson()
        {
            FanStar = new FanStar();
        }

        public override void Speculation(string something)
        {
            Console.WriteLine("代理伪装!");
            base.Speculation(something);
            Console.WriteLine("代理后期继续处理!");
        }
    }
}

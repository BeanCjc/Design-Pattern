using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 抽象类,定义代理类和真实对象类的公共接口
    /// </summary>
    public abstract class AgentAbstract
    {
        public virtual void Speculation(string something)
        {
            Console.WriteLine(something);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 具体的同事类ConcreteColleague
    /// </summary>
    public class DevelopmentConcreteColleague : Colleague
    {
        public DevelopmentConcreteColleague(Mediator mediator) : base(mediator) { }
        public override void Apply()
        {
            Console.WriteLine("专心科研,开发项目!");
        }

        public override void Process()
        {
            Console.WriteLine("我们是研发部门.要进行项目开发,没钱了,需要资金支持!");
        }
    }
}

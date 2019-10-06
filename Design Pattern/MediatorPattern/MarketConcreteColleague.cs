using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 具体的同事类ConcreteColleague
    /// </summary>
    public class MarketConcreteColleague : Colleague
    {
        public MarketConcreteColleague(Mediator mediator) : base(mediator) { }
        public override void Apply()
        {
            Console.WriteLine("跑去接项目！");
        }

        public override void Process()
        {
            Console.WriteLine("汇报工作！项目承接的进度，需要资金支持！");
            Mediator.Command(this);
        }
    }
}

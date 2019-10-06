using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 具体的同事类ConcreteColleague
    /// </summary>
    public class FinancialConcreteColleague : Colleague
    {
        public FinancialConcreteColleague(Mediator mediator) : base(mediator) { }

        public override void Apply()
        {
            Console.WriteLine("数钱");
        }

        public override void Process()
        {
            Console.WriteLine("我们是财务部门!汇报工作、没钱了...");
        }
    }
}

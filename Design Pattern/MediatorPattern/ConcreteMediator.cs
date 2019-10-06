using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 具体的中介者类
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        /// <summary>
        /// 中介者有各个Colleague的引用
        /// </summary>
        FinancialConcreteColleague FinancialConcreteColleague;
        DevelopmentConcreteColleague DevelopmentConcreteColleague;
        MarketConcreteColleague MarketConcreteColleague;

        /// <summary>
        /// 设置Colleague
        /// </summary>
        /// <param name="colleague"></param>
        public void SetFinancial(FinancialConcreteColleague colleague)
        {
            FinancialConcreteColleague = colleague;
        }

        public void SetDevelopment(DevelopmentConcreteColleague colleague)
        {
            DevelopmentConcreteColleague = colleague;
        }

        public void SetMarket(MarketConcreteColleague colleague)
        {
            MarketConcreteColleague = colleague;
        }

        /// <summary>
        /// 通过中介者来实现各个Colleague间的交互
        /// </summary>
        /// <param name="colleague"></param>
        public void Command(Colleague colleague)
        {
            if (colleague.GetType()==typeof(MarketConcreteColleague))
            {
                FinancialConcreteColleague.Process();
            }
        }
    }
}

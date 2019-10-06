using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------DediatorPattern--------------------");
            Console.WriteLine();
            var mediator = new ConcreteMediator();
            FinancialConcreteColleague financial = new FinancialConcreteColleague(mediator);
            DevelopmentConcreteColleague development = new DevelopmentConcreteColleague(mediator);
            MarketConcreteColleague market = new MarketConcreteColleague(mediator);
            mediator.SetFinancial(financial);
            mediator.SetDevelopment(development);
            mediator.SetMarket(market);
            market.Process();
            market.Apply();
            Console.ReadKey();
        }
    }
}

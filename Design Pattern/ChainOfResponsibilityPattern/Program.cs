using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------CharinOfResponsibilityPattern--------------------");
            Console.WriteLine();
            var request1 = new Request(30000, "两个车位");
            var request2 = new Request(80000, "一辆自行车");
            var request3 = new Request(200000, "一份外卖");
            ApproverHandler manager = new ManagerConcreteHandlerA("张三");
            ApproverHandler financial = new FinancialConcreteHandler("李四");
            ApproverHandler ceo = new CEOConcreteHandler("王五");
            manager.NextHandler = financial;
            financial.NextHandler = ceo;
            manager.HandleRequest(request1);
            Console.WriteLine("第1条流程----------------------------------");
            Console.WriteLine();
            manager.HandleRequest(request2);
            Console.WriteLine("第2条流程----------------------------------");
            Console.WriteLine();
            manager.HandleRequest(request3);
            Console.WriteLine("第3条流程----------------------------------");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class FinancialConcreteHandler : ApproverHandler
    {
        /// <summary>
        /// 具体处理角色,财务部经理审批
        /// </summary>
        /// <param name="name"></param>
        public FinancialConcreteHandler(string name) : base(name) { }
        public override void HandleRequest(Request request)
        {
            Console.WriteLine($"财务部经理{Name}通过了对金额为{request.Amount}元的商品{request.ProductName}的审批!");
            if (request.Amount > 100000 && null != NextHandler)
            {
                NextHandler.HandleRequest(request);
                return;
            }
            Console.WriteLine("流程到财务部门结束!");
        }
    }
}

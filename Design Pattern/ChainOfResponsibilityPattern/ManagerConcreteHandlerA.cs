using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 具体处理角色,本部门经理审批
    /// </summary>
    public class ManagerConcreteHandlerA : ApproverHandler
    {
        public ManagerConcreteHandlerA(string name) : base(name) { }

        /// <summary>
        /// 处理请求并判断是否需要下一个人执行
        /// </summary>
        /// <param name="request"></param>
        public override void HandleRequest(Request request)
        {
            Console.WriteLine($"部门经理{Name}通过了对金额为{request.Amount}元的商品{request.ProductName}的审批!");
            if (request.Amount > 50000 && null != NextHandler)
            {
                NextHandler.HandleRequest(request);
                return;
            }
            Console.WriteLine("流程到本部门结束!");
        }
    }
}

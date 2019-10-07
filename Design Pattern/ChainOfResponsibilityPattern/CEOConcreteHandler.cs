using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 具体处理角色,CEO审批
    /// </summary>
    public class CEOConcreteHandler : ApproverHandler
    {
        public CEOConcreteHandler(string name) : base(name) { }
        public override void HandleRequest(Request request)
        {
            Console.WriteLine($"CEO{Name}通过了对金额为{request.Amount}元的商品{request.ProductName}的审批!");
            Console.WriteLine("流程到CEO结束!");
        }
    }
}

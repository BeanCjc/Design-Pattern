using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 具体状态角色类,订单已受理并准备发货
    /// </summary>
    public class AcceptAndDeliver : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("我们已接收订单.准备发货");
            if (context.Minute < 30 && context.IsCancel)
            {
                Console.WriteLine("接收半小时之内可以取消订单!");
                context.SetState(new Cancel());
                //context.Request();
                return;
            }
            if (context.IsFinished == false)
            {
                context.SetState(new ConfirmReceipt());
                //context.Request();
            }
        }
    }
}

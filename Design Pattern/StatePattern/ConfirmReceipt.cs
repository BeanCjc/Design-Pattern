using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 具体状态角色类,订单确认收获状态
    /// </summary>
    public class ConfirmReceipt : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("检查货物,没问题可以签收!");
            context.SetState(new Success());
            //context.Request();
        }
    }
}

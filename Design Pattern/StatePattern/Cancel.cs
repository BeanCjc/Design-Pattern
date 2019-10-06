using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 具体状态角色类,订单取消状态
    /// </summary>
    public class Cancel : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("订单已取消!");
            context.IsFinished = true;
        }
    }
}

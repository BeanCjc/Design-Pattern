using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 具体状态角色,订单待受理状态
    /// </summary>
    public class WaitForAcceptance : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("我们开始受理,准备备货!");
            if (context.Minute < 30 && context.IsCancel)
            {
                Console.WriteLine("接受半小时之内可以取消订单!");
                context.SetState(new Cancel());
                //context.Request();
                return;
            }
            context.SetState(new AcceptAndDeliver());
            //context.Request();
        }
    }
}

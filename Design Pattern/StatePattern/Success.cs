using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 具体状态角色类,交易成功状态
    /// </summary>
    public class Success : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("订单完成!");
            context.IsFinished = true;
        }
    }
}

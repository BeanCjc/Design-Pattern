using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 抽象状态角色
    /// </summary>
    public interface State
    {
        /// <summary>
        /// 对于状态子类所具备的行为
        /// </summary>
        /// <param name="context"></param>
        void Handle(Context context);
    }
}

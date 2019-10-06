using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 环境角色类
    /// </summary>
    public class Context
    {
        /// <summary>
        /// 状态
        /// </summary>
        State State;
        public Context()
        {
            State = new WaitForAcceptance();
        }
        public int Minute { get; set; }
        public bool IsCancel { get; set; } = false;
        public bool IsFinished { get; set; } = false;
        public void SetState(State state)
        {
            State = state;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 抽象处理者角色,模拟采购审批人
    /// </summary>
    public abstract class ApproverHandler
    {

        public ApproverHandler(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 部门负责人名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 责任链的下一个处理人
        /// </summary>
        public ApproverHandler NextHandler { get; set; }

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandleRequest(Request request);
    }
}

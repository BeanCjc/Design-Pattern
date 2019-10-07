using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 请求,模拟采购请求
    /// </summary>
    public class Request
    {
        /// <summary>
        /// 采购金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 采购商品名称
        /// </summary>
        public string ProductName { get; set; }
        public Request(decimal amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}

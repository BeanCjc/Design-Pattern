using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// SqlServer2008版本数据库
    /// </summary>
    public class SqlServer2008 : Database
    {
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        /// <param name="platformImplementor"></param>
        public SqlServer2008(PlatformImplementor platformImplementor) : base(platformImplementor) { }
        public override void Create()
        {
            Console.WriteLine("SqlServer2008已创建");
            _platformImplementor.Process();
        }
    }
}

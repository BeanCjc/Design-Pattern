using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// SQLServer2017版本数据库
    /// </summary>
    public class SqlServer2017 : Database
    {
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        /// <param name="platformImplementor"></param>
        public SqlServer2017(PlatformImplementor platformImplementor) : base(platformImplementor) { }
        public override void Create()
        {
            Console.WriteLine("SqlServer2017已创建");
            _platformImplementor.Process();
        }
    }
}

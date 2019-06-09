using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Database
    {
        /// <summary>
        /// 通过组合方式引入平台接口,此处就是桥梁
        /// </summary>
        protected PlatformImplementor _platformImplementor;

        /// <summary>
        /// 通过构造器注入,初始化平台实现
        /// </summary>
        /// <param name="platformImplementor"></param>
        public Database(PlatformImplementor platformImplementor)
        {
            _platformImplementor = platformImplementor;
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        public abstract void Create();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 联系人,需要备份的数据
    /// </summary>
    public class Contact
    {
        public string Name { get; set; }
        public string MobileNumber { get; set; }
    }
}

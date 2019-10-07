using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录对象,保存状态数据
    /// </summary>
    public class ContactMemento
    {
        /// <summary>
        /// 备忘录ID
        /// </summary>
        public string ID { get; set; }
        public IList<Contact> ContactListBack { get; private set; }
        public ContactMemento(IList<Contact> contacts)
        {
            ContactListBack = contacts;
            ID = Guid.NewGuid().ToString();
        }
    }
}

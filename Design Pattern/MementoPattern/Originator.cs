using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// 发起人名称
        /// </summary>
        public string Name { get; set; }

        public IList<Contact> Contacts { get; set; }
        public Originator(string name, IList<Contact> contacts)
        {
            Name = name;
            Contacts = contacts;
        }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public ContactMemento CreateMemento()
        {
            return new ContactMemento(new List<Contact>(Contacts));
        }

        /// <summary>
        /// 从备忘录回复联系人
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(ContactMemento memento)
        {
            Contacts = memento.ContactListBack;
        }

        /// <summary>
        /// 显示联系人
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"联系人列表中共有{Contacts.Count}人,他们是:");
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"姓名:{contact.Name}   电话:{contact.MobileNumber}");
            }
        }
    }
}

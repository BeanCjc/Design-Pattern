using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 管理角色,可以管理备忘录对象
    /// </summary>
    public class MementoManager
    {
        public Dictionary<string, IList<ContactMemento>> ContactMementoList { get; set; } = new Dictionary<string, IList<ContactMemento>>();
        public void Show()
        {
            foreach (var item in ContactMementoList)
            {
                Console.WriteLine($"姓名:{item.Key}");
                foreach (var tempMemento in item.Value)
                {
                    Console.WriteLine($"    备忘录ID:{tempMemento.ID}");
                    Console.WriteLine($"    备忘录内容:");
                    foreach (var contact in tempMemento.ContactListBack)
                    {
                        Console.WriteLine($"        姓名:{contact.Name}    电话:{contact.MobileNumber}");
                    }
                }
            }
        }
    }
}

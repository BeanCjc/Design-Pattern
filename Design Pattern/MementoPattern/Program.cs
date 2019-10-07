using System;
using System.Collections.Generic;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------ObserverPattern--------------------");
            Console.WriteLine();
            IList<Contact> contacts = new List<Contact>
            {
                new Contact{Name="张三",MobileNumber="13566778901"},
                new Contact{Name="李四",MobileNumber="15835368686"},
                new Contact{Name="王五",MobileNumber="15160266300"}
            };
            var originator = new Originator("Bean", contacts);
            originator.Show();
            Console.WriteLine();

            //创建备忘录
            var manager = new MementoManager();
            var memento = originator.CreateMemento();
            manager.ContactMementoList.Add(originator.Name, new List<ContactMemento> { memento });
            manager.Show();
            Console.WriteLine();

            //修改通讯录
            Console.WriteLine("----------------移除最后一个联系人---------");
            originator.Contacts.RemoveAt(2);
            originator.Show();
            Console.WriteLine();

            //回复通讯录
            Console.WriteLine("----------------回复通讯录列表-------------");
            originator.RestoreMemento(memento);
            originator.Show();

            Console.ReadKey();
        }
    }
}

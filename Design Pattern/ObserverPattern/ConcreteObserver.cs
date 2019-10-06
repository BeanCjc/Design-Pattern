using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(string name) : base(name) { }
        public override void Update(Subject subject)
        {
            Console.WriteLine($"{Name}已接收到来自主题[{subject.Name}]的消息.消息内容是:{subject.Message}");
        }
    }
}

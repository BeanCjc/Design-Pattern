using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 具体的被主题实现类,具体的被观察者
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public ConcreteSubject(string name) : base(name) { }

        public override void PublishMessage(string message)
        {
            base.PublishMessage(message);
            Notify();
        }
    }
}

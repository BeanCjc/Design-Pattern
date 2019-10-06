using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象主题类,类似微信公众号或者叫订阅号
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// 订阅号名称
        /// </summary>
        public string Name { get; }
        public string Message { get; protected set; }
        protected IList<Observer> Observers;
        protected Subject(string name)
        {
            Name = name;
            Observers = new List<Observer>();
        }

        /// <summary>
        /// 订阅号发布消息
        /// </summary>
        /// <param name="message"></param>
        public virtual void PublishMessage(string message)
        {
            Message = message;
        }

        /// <summary>
        /// 添加订阅用户,可重写.实际上应该是用户添加和取消订阅,而不是订阅号做这个事情,故这个没有实际意义
        /// </summary>
        /// <param name="observer"></param>
        public virtual void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        /// <summary>
        /// 移除订阅用户,可重写.实际上应该是用户添加和取消订阅,而不是订阅号做这个事情,故这个没有实际意义
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public virtual bool RemoveObserver(Observer observer)
        {
            return Observers.Remove(observer);
        }

        /// <summary>
        /// 发送通知给订阅的用户
        /// </summary>
        public virtual void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}

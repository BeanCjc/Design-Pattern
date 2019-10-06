using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class Observer
    {
        /// <summary>
        /// 观察者的名称,类似订阅公众号的微信用户一样
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 某某微信用户所关注的订阅号
        /// </summary>
        protected IList<Subject> Subjects;
        protected Observer(string name)
        {
            Name = name;
            Subjects = new List<Subject>();
        }

        /// <summary>
        /// 更新.也就是被动接收来自订阅号的消息.可以传递一个Subject对象从而获取详细的被观察者的变化,也可以实现观察者拉模式
        /// </summary>
        /// <param name="subject"></param>
        public abstract void Update(Subject subject);

        /// <summary>
        /// 添加订阅,可重写
        /// </summary>
        /// <param name="subject"></param>
        public virtual void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
            subject.AddObserver(this);
        }

        /// <summary>
        /// 移除订阅,可重写
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public virtual bool RemoveSubject(Subject subject)
        {
            Subjects.Remove(subject);
            return subject.RemoveObserver(this);
        }
    }
}

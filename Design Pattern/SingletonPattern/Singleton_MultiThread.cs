using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton_MultiThread
    {
        //定义私有构造函数,使外界不能创建该类的实例
        private Singleton_MultiThread() { }

        //定义静态变量来保存类的实例
        private static volatile Singleton_MultiThread instance;

        //定义locker来保证线程同步
        private static readonly object locker = new object();

        /// <summary>
        /// 定义共有方法提供一个全局的访问点;同时也可以定义共有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        static Singleton_MultiThread GetInstance()
        {

            //当第一个线程运行到这里时会对locker对象加锁
            //当第二个线程运行到这里时,首先检测到locker对象为"加锁"状态,该线程就会挂起,直到第一个线程释放locker
            //当第一个线程的locker语句块运行完之后会对locker对象解锁
            //lock (locker)
            //{
            //    if (instance == null)
            //    {
            //        instance = new Singleton_MultiThread();
            //    }
            //}
            
            //采用双重锁定(double check)提升上面的性能开销
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton_MultiThread();
                    }
                }
            }
            return instance;
        }
    }
}

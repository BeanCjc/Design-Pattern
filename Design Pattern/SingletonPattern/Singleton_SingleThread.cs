using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// 单线程单例模式
    /// </summary>
    public sealed class Singleton_SingleThread
    {
        //定义私有构造函数,外部无法创建实例
        private Singleton_SingleThread() { }

        //定义静态变量来保存类的实例
        private static Singleton_SingleThread instance;

        /// <summary>
        /// 定义公有方法,提供一个全局的访问方法;也可以定义共有属性来支持全局访问
        /// </summary>
        /// <returns></returns>
        public static Singleton_SingleThread GetInstance()
        {
            //如果类的实例不存在则创建,否则直接返回实例
            if (instance == null)
            {
                instance = new Singleton_SingleThread();
            }
            return instance;
        }

        ///// <summary>
        ///// 公共属性获取全局的实例
        ///// </summary>
        //public static Singleton_SingleThread GetInstace666
        //{
        //    get
        //    {
        //        if (instance==null)
        //        {
        //            instance = new Singleton_SingleThread();
        //        }
        //        return instance;
        //    }
        //}
    }
}

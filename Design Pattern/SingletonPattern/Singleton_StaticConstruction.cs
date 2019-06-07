using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// 静态构造函数的单例模式,同样支持多线程,因为静态构造函数只会在一个线程中执行一次,不会在多个线程中执行
    /// </summary>
    public sealed class Singleton_StaticConstruction
    {
        private Singleton_StaticConstruction() { }

        //内联初始化(生产的同时初始化)的单例模式
        public readonly static Singleton_StaticConstruction instance = new Singleton_StaticConstruction();

        //相当于以上内敛写法
        //public static readonly Singleton_StaticConstruction instance;
        ////静态构造函数必须是无参,私有的且只能有一个
        //static Singleton_StaticConstruction()
        //{
        //    instance = new Singleton_StaticConstruction();
        //}
    }
}

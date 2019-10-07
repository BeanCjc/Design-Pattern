using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------BridgePattern--------------------");
            Console.WriteLine();

            //平台和数据库版本是两个完全不同的维度,平台维度作为数据库的一个成员

            #region 原始写法,每个平台都要写
            //SqlServer2008,Unix平台
            PlatformImplementor unixPlatform2008 = new SqlServer2008UnixImplementor();
            Database sqlServer2008Unix = new SqlServer2008(unixPlatform2008);
            sqlServer2008Unix.Create();

            //SqlServer2017,Unix平台
            PlatformImplementor unixPlatform2017 = new SqlServer2017UnixImplementor();
            Database sqlServer2017Unix = new SqlServer2017(unixPlatform2017);
            sqlServer2017Unix.Create();

            //SqlServer2008,Windows平台
            PlatformImplementor windowsPlatform2008 = new SqlServer2008WindowsImplementor();
            Database sqlServer2008Windows = new SqlServer2008(windowsPlatform2008);
            sqlServer2008Windows.Create();

            //SqlServer2017,Windows平台
            PlatformImplementor windowsPlatform2017 = new SqlServer2017WindowsImplementor();
            Database sqlServer2017Windows = new SqlServer2017(unixPlatform2017);
            sqlServer2017Windows.Create();

            #endregion


            Console.WriteLine("-----------------------------------------------------");
            #region 数据库版本和平台完全分离的写法
            //unxi平台
            PlatformImplementor unix = new UnixImplementor();
            //Windows平台
            PlatformImplementor windows = new WindowsImplementor();

            //SqlServer2008，Unix平台
            Database sqlServer2008UnixPlatform = new SqlServer2008(unix);
            sqlServer2008UnixPlatform.Create();

            //Sqlserver2017,Unix平台
            Database sqlServer2017UnixPlatform = new SqlServer2017(unix);
            sqlServer2017UnixPlatform.Create();

            //SqlServer2008,Windows平台
            Database sqlServer2008WindowsPlatform = new SqlServer2008(windows);
            sqlServer2008WindowsPlatform.Create();

            //SqlServer2017,Windows平台
            Database sqlServer2017WindowsPlatform = new SqlServer2017(windows);
            sqlServer2017WindowsPlatform.Create();
            Console.WriteLine("-----------------------------------------------------");

            #endregion


            Console.ReadLine();
        }
    }
}

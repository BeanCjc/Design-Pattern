using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// 汽车类
    /// </summary>
    public sealed class Car
    {
        //汽车部件集合
        IList<string> parts = new List<string>();

        /// <summary>
        /// 提供给外部添加汽车部件的方法
        /// </summary>
        /// <param name="part">部件名称</param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        /// <summary>
        /// 显示汽车
        /// </summary>
        public void Show()
        {
            Console.WriteLine("汽车开始组装...");
            foreach (var part in parts)
            {
                Console.WriteLine($"组件{part}已装好");
            }
            Console.WriteLine("汽车组装好了");
        }
    }
}

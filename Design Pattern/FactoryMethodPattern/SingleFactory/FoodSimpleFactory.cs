using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SingleFactory
{
    /// <summary>
    /// 简单工厂,负责炒菜
    /// </summary>
    public class FoodSimpleFactory
    {
        /// <summary>
        /// 静态方法,负责炒菜
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambleEggs();
            }
            return food;
        }
    }
}

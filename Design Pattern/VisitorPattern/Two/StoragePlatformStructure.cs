using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Two
{
    public class StoragePlatformStructure
    {
        IList<GoodsElement> goodsList = new List<GoodsElement>();

        public void Attach(GoodsElement goods)
        {
            goodsList.Add(goods);
        }

        public bool Detach(GoodsElement goods)
        {
            return goodsList.Remove(goods);
        }

        public void Operate(Visitor visitor)
        {
            foreach (var goods in goodsList)
            {
                goods.Operate(visitor);
            }
        }
    }
}

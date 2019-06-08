using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypepattern
{
    public sealed class XingZheSunPrototype : Prototype
    {
        public XingZheSunPrototype() { }
        public XingZheSunPrototype(string name)
        {
            Name = name;
        }
        public override void BegAlms() => Console.WriteLine($"行者孙--{Name}乞讨");

        public override Prototype Clone() => (XingZheSunPrototype)MemberwiseClone();

        public override void Fight() => Console.WriteLine($"行者孙--{Name}战斗");
    }
}

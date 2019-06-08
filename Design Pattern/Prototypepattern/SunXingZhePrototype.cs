using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypepattern
{
    public sealed class SunXingZhePrototype : Prototype
    {
        public SunXingZhePrototype() { }
        public SunXingZhePrototype(string name)
        {
            Name = name;
        }
        public override void BegAlms() => Console.WriteLine($"孙行者--{Name}乞讨");

        public override Prototype Clone() => (SunXingZhePrototype)MemberwiseClone();
        
        public override void Fight() => Console.WriteLine($"孙行者--{Name}战斗");
    }
}

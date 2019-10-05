using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public sealed class SoldierFactory
    {
        private static IList<Soldier> soldiers;
        static SoldierFactory()
        {
            soldiers = new List<Soldier>();
        }
        Soldier Soldier = null;
        public Soldier GetSoldier(string name, Weapen weapen, SoldierType soldierType)
        {
            foreach (var soldier in soldiers)
            {
                if (string.Compare(soldier.Name, name, true) == 0)
                {
                    Soldier = soldier;
                    return Soldier;
                }
            }
            if (soldierType==SoldierType.Normal)
            {
                Soldier = new NormalSoldier(name);
            }
            if (soldierType==SoldierType.Water)
            {
                Soldier = new WaterSoldier(name);
            }
            Soldier.WeapenInstance = weapen;
            soldiers.Add(Soldier);
            return Soldier;
        }
    }
}

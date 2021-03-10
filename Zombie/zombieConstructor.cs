using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ.Zombie
{
    public class zombieConstructor
    {
        public zombieConstructor(zombieType type, bool h, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hasHat = h;
            isAlive = a;
            hatHP = hhp;
            ZomHP = zhp;
        }
        public zombieType typeZ { get; set; }
        public bool hasHat { get; set; }
        public bool isAlive { get; set; }
        public int hatHP { get; set; }
        public int ZomHP { get; set; }
        
        
    }
}

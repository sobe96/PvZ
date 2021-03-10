using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class doorZombie : zombie
    {
        public static bool hasHat;
        public static bool isAlive;
        private static int hatHP;
        public static zombieType typeZ;
        public static int ZomDoorHP;

        public doorZombie(zombieType type, bool h, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomDoorHP = zhp;
        }
        public static void zombieIsHit()
        {
            if (hasHat)
            {
                if (hatHP > 0)
                {
                    Console.Clear();
                    Console.Write("SHTR         " + hatHP + "/" + ZomDoorHP);
                    //Overkill hat damage. Can be commented to disable overkill feature
                    int dif = hatHP - DMG;
                    if (dif < 0)
                    {
                        hatHP = 0;
                        ZomDoorHP += dif;
                    }
                    // End of overkill feature
                    hatHP -= DMG;
                }
                else
                {
                    hasHat = false;
                    Console.Clear();
                    Console.Write("SHTR         " + "0/" + ZomDoorHP);
                    ZomDoorHP -= DMG;
                }
            }
            else
            {
                if (ZomDoorHP > 0)
                {
                    Console.Clear();
                    Console.Write("SHTR         " + "0/" + ZomDoorHP);
                    ZomDoorHP -= DMG;
                }
                else
                {
                    isDead(PvZ.Configs.zombieType.doorZombie);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class roadConeZombie : zombie
    {
        public static bool hasHat;
        public static bool isAlive;
        private static int hatHP;
        public static zombieType typeZ;
        public static int ZomConeHP;

        public roadConeZombie(zombieType type, bool h, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomConeHP = zhp;
        }
        public static void zombieIsHit()
        {
            if (hasHat)
            {
                if (hatHP > 0)
                {
                    Console.Clear();
                    Console.Write("SHTR         " + hatHP + "/" + ZomConeHP);
                    //Overkill hat damage. Can be commented to disable overkill feature
                    int dif = hatHP - DMG;
                    if (dif < 0)
                    {
                        hatHP = 0;
                        ZomConeHP += dif;
                    }
                    // End of overkill feature
                    hatHP -= DMG;
                }
                else
                {
                    hasHat = false;
                    Console.Clear();
                    Console.Write("SHTR         " + "0/" + ZomConeHP);
                    ZomConeHP -= DMG;
                }
            }
            else
            {
                if (ZomConeHP > 0)
                {
                    Console.Clear();
                    Console.Write("SHTR         " + "0/" + ZomConeHP);
                    ZomConeHP -= DMG;
                }
                else
                {
                    isDead(PvZ.Configs.zombieType.roadConeZombie);
                }
            }
        }
    }
}

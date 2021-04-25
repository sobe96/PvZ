using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class doorZombie : zombie
    {
        public static bool hasHat;
        public static bool emptyHead;
        public static bool isAlive;
        private static int hatHP;
        public static zombieType typeZ;
        public static int ZomDoorHP;

        public doorZombie(zombieType type, bool h, bool e, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomDoorHP = zhp;
            emptyHead = e;
        }
        public static void zombieIsHit(bool airDrop)
        {
            if (airDrop)
            {
                if (emptyHead)
                {
                    ZomDoorHP -= AIRDMG;
                    if (ZomDoorHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomDoorHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.doorZombie);
                    }
                }
                else
                {
                    if (hasHat)
                    {
                        if (hatHP > 0)
                        {
                            //Overkill hat damage. Can be commented to disable overkill feature
                            int dif = hatHP - AIRDMG;
                            if (dif < 0)
                            {
                                hatHP = 0;
                                ZomDoorHP += dif;
                            }
                            // End of overkill feature
                            hatHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + hatHP + "/" + ZomDoorHP);
                        }
                        else
                        {
                            hasHat = false;
                            ZomDoorHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomDoorHP);
                        }
                    }
                    else
                    {
                        if (ZomDoorHP > 0)
                        {

                            ZomDoorHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomDoorHP);
                        }
                        else
                        {
                            isDead(PvZ.Configs.zombieType.doorZombie);
                        }
                    }
                }
            }
            else
            {
                if (hasHat)
                {
                    if (hatHP > 0)
                    {
                        //Overkill hat damage. Can be commented to disable overkill feature
                        int dif = hatHP - DMG;
                        if (dif < 0)
                        {
                            hatHP = 0;
                            ZomDoorHP += dif;
                        }
                        // End of overkill feature
                        hatHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomDoorHP);
                    }
                    else
                    {
                        hasHat = false;
                        ZomDoorHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomDoorHP);
                    }
                }
                else
                {
                    if (ZomDoorHP > 0)
                    {
                        ZomDoorHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomDoorHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.doorZombie);
                    }
                }
            }
        }
    }
}

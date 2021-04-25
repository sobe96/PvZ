using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class noGearZombie : zombie
    {
        public static bool hasHat;
        public static bool emptyHead;
        public static bool isAlive;
        public static int hatHP;
        public static zombieType typeZ;
        public static int ZomRegHP;

        public noGearZombie(zombieType type, bool h, bool e, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomRegHP = zhp;
            emptyHead = e;
        }
        public static void zombieIsHit(bool airDrop)
        {
            if (airDrop)
            {
                if (emptyHead)
                {
                    ZomRegHP -= AIRDMG;
                    if (ZomRegHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomRegHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.noGearZombie);
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
                                ZomRegHP += dif;
                            }
                            // End of overkill feature
                            hatHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + hatHP + "/" + ZomRegHP);
                        }
                        else
                        {
                            hasHat = false;
                            ZomRegHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomRegHP);
                        }
                    }
                    else
                    {
                        if (ZomRegHP > 0)
                        {

                            ZomRegHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomRegHP);
                        }
                        else
                        {
                            isDead(PvZ.Configs.zombieType.noGearZombie);
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
                            ZomRegHP += dif;
                        }
                        // End of overkill feature
                        hatHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomRegHP);
                    }
                    else
                    {
                        hasHat = false;
                        ZomRegHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomRegHP);
                    }
                }
                else
                {
                    if (ZomRegHP > 0)
                    {
                        ZomRegHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomRegHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.noGearZombie);
                    }
                }
            }
        }
    }
}

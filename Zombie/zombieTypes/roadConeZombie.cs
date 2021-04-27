using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class roadConeZombie : zombie
    {
        public static bool hasHat;
        public static bool emptyHead;
        public static bool isAlive;
        public static int hatHP;
        public static zombieType typeZ;
        public static int ZomConeHP;
        public static bool isMetal = false;

        public roadConeZombie(zombieType type, bool h, bool e, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomConeHP = zhp;
            emptyHead = e;
        }
        public static void zombieIsHit(bool airDrop)
        {
            if (airDrop)
            {
                if (emptyHead)
                {
                    ZomConeHP -= AIRDMG;
                    if (ZomConeHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomConeHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.roadConeZombie);
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
                                ZomConeHP += dif;
                            }
                            else
                            {
                                hatHP -= AIRDMG;
                            }
                            // End of overkill feature
                            
                            Console.Clear();
                            Console.Write("SHTR         " + hatHP + "/" + ZomConeHP);
                        }
                        else
                        {
                            hasHat = false;
                            ZomConeHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomConeHP);
                        }
                    }
                    else
                    {
                        ZomConeHP -= AIRDMG;
                        if (ZomConeHP > 0)
                        {
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomConeHP);
                        }
                        else
                        {
                            isDead(PvZ.Configs.zombieType.roadConeZombie);
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
                            ZomConeHP += dif;
                        }
                        // End of overkill feature
                        hatHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomConeHP);
                    }
                    else
                    {
                        hasHat = false;
                        ZomConeHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomConeHP);
                    }
                }
                else
                {
                    ZomConeHP -= DMG;
                    if (ZomConeHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomConeHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.roadConeZombie);
                    }
                }
            }
            
        }
    }
}

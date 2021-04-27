using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;

namespace PvZ.Zombie.zombieTypes
{
    class bucketHeadZombie : zombie
    {
        public static bool hasHat;
        public static bool emptyHead;
        public static bool isAlive;
        public static int hatHP;
        public static zombieType typeZ;
        public static int ZomBuckHP;
        public static bool isMetal = true;

        public bucketHeadZombie(zombieType type, bool h, bool e, bool a, int hhp, int zhp)
        {
            typeZ = type;
            hatHP = hhp;
            hasHat = h;
            isAlive = a;
            ZomBuckHP = zhp;
            emptyHead = e;
        }
        public static void zombieIsHit(bool airDrop)
        {
            if (airDrop)
            {
                if (emptyHead)
                {
                    ZomBuckHP -= AIRDMG;
                    if (ZomBuckHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomBuckHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.bucketHeadZombie);
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
                                ZomBuckHP += dif;
                            }
                            // End of overkill feature
                            hatHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + hatHP + "/" + ZomBuckHP);
                        }
                        else
                        {
                            hasHat = false;
                            ZomBuckHP -= AIRDMG;
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomBuckHP);
                        }
                    }
                    else
                    {
                        ZomBuckHP -= AIRDMG;
                        if (ZomBuckHP > 0)
                        {
                            Console.Clear();
                            Console.Write("SHTR         " + "0/" + ZomBuckHP);
                        }
                        else
                        {
                            isDead(PvZ.Configs.zombieType.bucketHeadZombie);
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
                            ZomBuckHP += dif;
                        }
                        // End of overkill feature
                        hatHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + hatHP + "/" + ZomBuckHP);
                    }
                    else
                    {
                        hasHat = false;
                        ZomBuckHP -= DMG;
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomBuckHP);
                    }
                }
                else
                {
                    ZomBuckHP -= DMG;
                    if (ZomBuckHP > 0)
                    {
                        Console.Clear();
                        Console.Write("SHTR         " + "0/" + ZomBuckHP);
                    }
                    else
                    {
                        isDead(PvZ.Configs.zombieType.bucketHeadZombie);
                    }
                }
            }
        }
    }
}

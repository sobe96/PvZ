using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ.Zombie
{
    public abstract class zombie
    {
        public static int DMG;
        public static int AIRDMG;
        public static bool deadState = false;
        public static bool isMetal;

        public static void IsHit(zombieType type, bool airDrop)
        {
            switch(type)
            {
                case zombieType.noGearZombie:
                    noGearZombie.zombieIsHit(airDrop);
                    break;
                case zombieType.roadConeZombie:
                    roadConeZombie.zombieIsHit(airDrop);
                    break;
                case zombieType.doorZombie:
                    doorZombie.zombieIsHit(airDrop);
                    break;
                case zombieType.bucketHeadZombie:
                    bucketHeadZombie.zombieIsHit(airDrop);
                    break;
            }
        }
        public static string InitShow(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    if (noGearZombie.hasHat)
                    {
                        return "SHTR         " + noGearZombie.hatHP + "/" + noGearZombie.ZomRegHP;
                    }
                    else
                    {
                        return "SHTR         " + 0 + "/" + noGearZombie.ZomRegHP;
                    }
                case zombieType.roadConeZombie:
                    if (roadConeZombie.hasHat)
                    {
                        return "SHTR         " + roadConeZombie.hatHP + "/" + roadConeZombie.ZomConeHP;
                    }
                    else
                    {
                        return "SHTR         " + 0 + "/" + roadConeZombie.ZomConeHP;
                    }
                case zombieType.doorZombie:
                    if (doorZombie.hasHat)
                    {
                        return "SHTR         " + doorZombie.hatHP + "/" + doorZombie.ZomDoorHP;
                    }
                    else
                    {
                        return "SHTR         " + 0 + "/" + doorZombie.ZomDoorHP;
                    }
                case zombieType.bucketHeadZombie:
                    if (bucketHeadZombie.hasHat)
                    {
                        return "SHTR         " + bucketHeadZombie.hatHP + "/" + bucketHeadZombie.ZomBuckHP;
                    }
                    else
                    {
                        return "SHTR         " + 0 + "/" + bucketHeadZombie.ZomBuckHP;
                    }
                default:
                    throw new ArgumentException();
            }
        }
        public static bool zombieState(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    return noGearZombie.isAlive;
                case zombieType.roadConeZombie:
                    return roadConeZombie.isAlive;
                case zombieType.doorZombie:
                    return doorZombie.isAlive;
                case zombieType.bucketHeadZombie:
                    return bucketHeadZombie.isAlive;
                default:
                    throw new ArgumentException();
            }
        }
        public static void isDead(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    noGearZombie.isAlive = false;
                    break;
                case zombieType.roadConeZombie:
                    roadConeZombie.isAlive = false;
                    break;
                case zombieType.doorZombie:
                    doorZombie.isAlive = false;
                    break;
                case zombieType.bucketHeadZombie:
                    bucketHeadZombie.isAlive = false;
                    break;
            }
            Console.Clear();
            Console.WriteLine("Zombie is dead");
            Console.WriteLine("Press Enter to continue");
            deadState = true;
        }
        public static void isDropped(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    noGearZombie.hasHat = false;
                    noGearZombie.hatHP = 0;
                    break;
                case zombieType.roadConeZombie:
                    roadConeZombie.hasHat = false;
                    roadConeZombie.hatHP = 0;
                    break;
                case zombieType.doorZombie:
                    doorZombie.hasHat = false;
                    doorZombie.hatHP = 0;
                    break;
                case zombieType.bucketHeadZombie:
                    bucketHeadZombie.hasHat = false;
                    bucketHeadZombie.hatHP = 0;
                    break;
            }
        }
    } 
}

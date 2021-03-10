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
        public static int HP;
        public static int ZomHP = 50;
        public static int DMG = 10;

        public static void IsHit(zombieType type)
        {
            switch(type)
            {
                case zombieType.noGearZombie:
                    noGearZombie.zombieIsHit();
                    break;
                case zombieType.roadConeZombie:
                    roadConeZombie.zombieIsHit();
                    break;
                case zombieType.doorZombie:
                    doorZombie.zombieIsHit();
                    break;
                case zombieType.bucketHeadZombie:
                    bucketHeadZombie.zombieIsHit();
                    break;
            }
        }
        public static bool switchZombie(zombieType type)
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
            Console.Write("Zombie is dead");
        }
        /*public static void isDropped(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    noGearZombie.hasHat = false;
                    break;
                case zombieType.roadConeZombie:
                    roadConeZombie.hasHat = false;
                    break;
                case zombieType.doorZombie:
                    doorZombie.hasHat = false;
                    break;
                case zombieType.bucketHeadZombie:
                    bucketHeadZombie.hasHat = false;
                    break;
            }
        }*/
    } 
}

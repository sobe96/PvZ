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
                    return "SHTR         " + 0 + "/" + 50;
                case zombieType.roadConeZombie:
                    return "SHTR         " + 25 + "/" + 50;
                case zombieType.doorZombie:
                    return "SHTR         " + 25 + "/" + 50;
                case zombieType.bucketHeadZombie:
                    return "SHTR         " + 100 + "/" + 50;
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
        }
    } 
}

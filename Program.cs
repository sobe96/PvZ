﻿using System;
using System.Threading;
using System.Collections.Generic;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ
{
    public sealed class Program
    {
        public static List<zombie> zombieList = new List<zombie>();
        public static zombieFactory factory = new zombieFactory();
        public static bool inGame = false;
        public static int i;

        public static void addZombie(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    var newZom = (noGearZombie)factory.GetZombie(zombieType.noGearZombie);
                    zombieList.Add(newZom);
                    break;
                case zombieType.roadConeZombie:
                    var newRZom = (roadConeZombie)factory.GetZombie(zombieType.roadConeZombie);
                    zombieList.Add(newRZom);
                    break;
                case zombieType.bucketHeadZombie:
                    var newBZom = (bucketHeadZombie)factory.GetZombie(zombieType.bucketHeadZombie);
                    zombieList.Add(newBZom);
                    break;
                case zombieType.doorZombie:
                    var newDZom = (doorZombie)factory.GetZombie(zombieType.doorZombie);
                    zombieList.Add(newDZom);
                    break;
            }
        }
        public static void Main()
        {
            while (inGame)
            {
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Spacebar)
                {
                    if (i >= zombieList.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("All Zombies are dead! Congratulations!");
                        Console.ReadLine();
                    }
                    else
                    {
                        hitNext(i);
                        if (!IsAlive(i))
                        {
                            i++;
                        }
                    } 
                }
            }
            i = 0;
            mainMenu.Menu();
            Console.ReadLine();
        }
        public static string prettyName(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    return "A Regular Zombie";
                case zombieType.roadConeZombie:
                    return "A Roadcone Zombie";
                case zombieType.bucketHeadZombie:
                    return "A Bucket Zombie";
                case zombieType.doorZombie:
                    return "A Door Zombie";
                default:
                    throw new ArgumentException();
            }
        }
        public static bool IsAlive (int k)
        {
            bool state = zombie.switchZombie(GetZombieType(k));
            switch (state)
            {
                case true:
                    return true;
                case false:
                    return false;
                default:
                    throw new ArgumentException();
            }
        }
        public static zombieType GetZombieType(int k)
        {
              switch (zombieList[k])
            {
                case noGearZombie:
                    return zombieType.noGearZombie;
                case roadConeZombie:
                    return zombieType.roadConeZombie;
                case bucketHeadZombie:
                    return zombieType.bucketHeadZombie;
                case doorZombie:
                    return zombieType.doorZombie;
                default:
                    throw new ArgumentException();
            }
        }
        public static zombieType GetZombieType(zombie name)
        {
            switch (name)
            {
                case noGearZombie:
                    return zombieType.noGearZombie;
                case roadConeZombie:
                    return zombieType.roadConeZombie;
                case bucketHeadZombie:
                    return zombieType.bucketHeadZombie;
                case doorZombie:
                    return zombieType.doorZombie;
                default:
                    throw new ArgumentException();
            }
        }
        public static void hitNext(int i)
        {
            var type = GetZombieType(i);
            zombie.IsHit(type);
        }
    }
}
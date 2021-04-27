using System;
using System.Threading;
using System.Collections.Generic;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ
{
    class GameEventManager
    {
        public static int PeaShooter(int i)
        {
            bool airDrop = false;
            if (i >= GameObjectManager.zombieList.Count)
            {
                Console.Clear();
                Console.WriteLine("All Zombies are dead! Your brains are safe... for now.");
                Console.ReadLine();
            }
            else
            {
                Program.hitNext(i, airDrop);
                if (!Program.IsAlive(i))
                {
                    i++;
                }
            }
            return i;
        }

        public static int WaterMelon(int i)
        {
            bool airDrop = true;
            if (i >= GameObjectManager.zombieList.Count)
            {
                Console.Clear();
                Console.WriteLine("All Zombies are dead! Your brains are safe... for now.");
                Console.ReadLine();
            }
            else
            {
                Program.hitNext(i, airDrop);
                if (!Program.IsAlive(i))
                {
                    i++;
                }
            }
            return i;
        }

        public static int MagnetShroom(int i)
        {
            if (i >= GameObjectManager.zombieList.Count)
            {
                Console.Clear();
                Console.WriteLine("All Zombies are dead! Your brains are safe... for now.");
                Console.ReadLine();
            }
            else
            {
                var type = Program.GetZombieType(i);
                Program.loseHatNext(i);
                Console.Clear();
                Console.Write(zombie.InitShow(type));
            }
            return i;
        }
    }
}

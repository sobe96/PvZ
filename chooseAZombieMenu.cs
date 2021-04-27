using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ
{
    class chooseAZombieMenu
    {
        public static void choiceMenu()
        {
            Console.Write("1. A regular zombie\n" +
                "2. A zombie with a Road Cone\n" +
                "3. A zombie with a Bucket\n" +
                "4. A zombie with a Door\n\n" +
                "List of Zombies\n");
            if (GameObjectManager.zombieList.Count == 0)
            {
                Console.WriteLine("There are no zombies yet");
            }
            else
            {
                foreach (var zom in GameObjectManager.zombieList)
                {
                    var type = Program.GetZombieType(zom);
                    string niceType = Program.prettyName(type);
                    Console.WriteLine(niceType);
                }
            }
            Console.WriteLine("\n");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.D1)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Program.addZombie(zombieType.noGearZombie);
                    Console.Clear();
                    mainMenu.Menu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    choiceMenu();
                }
            }
            if (keyInfo.Key == ConsoleKey.D2)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Program.addZombie(zombieType.roadConeZombie);
                    Console.Clear();
                    mainMenu.Menu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    choiceMenu();
                }
            }
            if (keyInfo.Key == ConsoleKey.D3)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Program.addZombie(zombieType.bucketHeadZombie);
                    Console.Clear();
                    mainMenu.Menu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    choiceMenu();
                }
            }
            if (keyInfo.Key == ConsoleKey.D4)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Program.addZombie(zombieType.doorZombie);
                    Console.Clear();
                    mainMenu.Menu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    choiceMenu();
                }
            }
            if (keyInfo.Key == ConsoleKey.Backspace)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    mainMenu.Menu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    choiceMenu();
                }
            }
            Console.Clear();
            //Console.Write("      \r");
        }
    }
}

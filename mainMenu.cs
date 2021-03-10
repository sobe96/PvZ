﻿using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;
using PvZ.Factories;

namespace PvZ
{
    public static class mainMenu
    {
        public static void Menu()
        {
            Console.Write("1. Add a zombie\n" +
                "2. Start\n\n" +
                "List of Zombies\n");
            if (Program.zombieList.Count == 0)
            {
                Console.WriteLine("There are no zombies yet");
            }
            else
            {
                foreach (var zom in Program.zombieList)
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
                    Console.Clear();
                    chooseAZombieMenu.choiceMenu();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Program.Main();
                }
            }
            if (keyInfo.Key == ConsoleKey.D2)
            {
                Console.WriteLine("\nPress Enter to confirm or Backspace to cancel");
                ConsoleKeyInfo keyInfoConf = Console.ReadKey();
                if (keyInfoConf.Key == ConsoleKey.Enter)
                {
                    Program.inGame = true;
                    Console.Clear();
                    Program.hitNext(0);
                    Program.Main();
                }
                if (keyInfoConf.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Menu();
                }
            }
            Console.Clear();
        }
    }
}

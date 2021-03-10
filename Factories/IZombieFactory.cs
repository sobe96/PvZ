using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;

namespace PvZ.Factories
{
    interface IZombieFactory
    {
        zombie GetZombie(zombieType type);
    }
}

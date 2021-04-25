using System;
using System.Collections.Generic;
using System.Text;
using PvZ.Configs;
using PvZ.Zombie;
using PvZ.Zombie.zombieTypes;

namespace PvZ.Factories
{
    public class zombieFactory : IZombieFactory
    {
        public zombie GetZombie(zombieType type)
        {
            switch (type)
            {
                case zombieType.noGearZombie:
                    return new noGearZombie(type, false, true, true, 0, 50);
                case zombieType.roadConeZombie:
                    return new roadConeZombie(type, true, false, true, 25, 50);
                case zombieType.bucketHeadZombie:
                    return new bucketHeadZombie(type, true, false, true, 100, 50);
                case zombieType.doorZombie:
                    return new doorZombie(type, true, true, true, 25, 50);
                default:
                    throw new ArgumentException();
            }
        }
    }
}

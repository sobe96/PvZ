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
                    return new noGearZombie(type, false, true, 0, 50);
                case zombieType.roadConeZombie:
                    return new roadConeZombie(type, true, true, 25, 50);
                case zombieType.bucketHeadZombie:
                    return new bucketHeadZombie(type, true, true, 50, 50);
                case zombieType.doorZombie:
                    return new doorZombie(type, true, true, 70, 50);
                default:
                    throw new ArgumentException();
            }
        }
    }
}

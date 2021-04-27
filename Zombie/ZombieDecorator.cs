using System;
using System.Collections.Generic;
using System.Text;

namespace PvZ.Zombie
{
    abstract class ZombieDecorator : zombie
    {
        protected zombie zombie;
        public ZombieDecorator(zombie zombie)
        {
            this.zombie = zombie;
        }
        //It's not implemented yet
    }
}

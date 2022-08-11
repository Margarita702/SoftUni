using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public Weapon(string name, int durability)
        {

        }
        public string Name => throw new NotImplementedException();

        public int Durability => throw new NotImplementedException();

        public int DoDamage()
        {
            throw new NotImplementedException();
        }
    }
}

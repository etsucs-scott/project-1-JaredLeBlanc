using AdventureGame.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    public class Monster : ICharacter 
    {
        const int BaseDamage = 8;

        public int Health { get; set; }
        public bool IsAlive => Health > 0;

        public Monster(int health)
        {
            Health = health;
        }

        public int Attack()
        {
            return BaseDamage;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }
    }
}

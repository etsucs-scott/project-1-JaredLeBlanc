using AdventureGame.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    // class to create the player object and implement ICharacter.
    public class Player : ICharacter
    {
        const int BaseDamage = 10;
        const int MaxHealth = 150;

        public int Health { get; set; }
        public bool IsAlive => Health > 0;

        public List<Weapon> Inventory { get; }

        public Player()
        {
            Health = 100;
            Inventory = new List<Weapon>();
        }

        public void AddWeapon(Weapon weapon)
        {
            Inventory.Add(weapon);
        }

        public void Heal(int amount)
        {
            Health = Math.Min(MaxHealth, Health + amount);
        }

        public int Attack()
        {
            int bestModifier = Inventory.Any()
                ? Inventory.Max(w => w.AttackModifier)
                : 0;

            return BaseDamage + bestModifier;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }
    }
}

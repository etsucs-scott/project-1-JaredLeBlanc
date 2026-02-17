using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    public class Weapon : Item
    {
        public int AttackModifier { get; }

        public Weapon(string name, int modifier) : base(name, $"You picked up {name}!")
        {
            AttackModifier = modifier;
        }

        public override void ApplyEffect(Player player)
        {
            player.AddWeapon(this);
        }
    }
}

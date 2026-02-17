using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    public class Potion : Item
    {
        const int HealAmount = 20;

        public Potion() : base("Potion", "Drink the potion to recover 20HP!")
        {

        }

        public override void ApplyEffect(Player player)
        {
            player.Heal(HealAmount);
        }
    }
}

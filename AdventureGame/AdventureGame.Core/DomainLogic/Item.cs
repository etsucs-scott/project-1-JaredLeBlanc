using AdventureGame.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    
    public abstract class Item
    {
        public string Name { get; set; }
        public string PickupMessage { get; set; }

        public Item(string name, string message)
        {
            Name = name;
            PickupMessage = message;
        }

        public abstract void ApplyEffect(Player player);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.Interfaces
{
    public interface ICharacter
    {
        int Health { get; }
        bool IsAlive { get; }

        void TakeDamage(int amount);
        int Attack();

    }
}

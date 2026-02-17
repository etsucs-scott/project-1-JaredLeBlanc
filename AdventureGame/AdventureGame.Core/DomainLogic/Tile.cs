using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    // class for the tile object
    public class Tile
    {
        public TileType Type { get; set; }
        public Monster? Monster { get; set; }
        public Item? Item { get; set; }

        public Tile(TileType type)
        {
            Type = type;
        }

        // clears a tile spot
        public void Clear()
        {
            Type = TileType.Empty;
            Monster = null;
            Item = null;
        }
    }
}

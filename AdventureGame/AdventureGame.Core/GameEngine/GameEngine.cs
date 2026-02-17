using AdventureGame.Core.DomainLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.GameEngine
{
    public class GameEngine
    {
        public Player Player { get; }
        public Maze Maze { get; }
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public string LastMessage { get; set; } = "";
        public bool GameOver { get; set; }
        public bool PlayerWin { get; set;}

        public GameEngine()
        {
            Player = new Player();
            Maze = new Maze(15, 15);
            PlayerX = 1;
            PlayerY = 1;
            Maze.Grid[PlayerX, PlayerY].Type = TileType.Empty;
        }

        public void Move(int dx, int dy)
        {
            if (GameOver) return;

            int newX = PlayerX + dx;
            int newY = PlayerY + dy;

            if (newX < 0 || newY < 0 || newX >= Maze.Width || newY >= Maze.Height)
            {
                LastMessage = "You cannot leave the maze!";
                return;
            }

            var tile = Maze.Grid[newX, newY];

            if (tile.Type == TileType.Wall)
            {
                LastMessage = "A wall black your path!";
                return;
            }

            PlayerX = newX;
            PlayerY = newY;

            TileHandle(tile);
        }

        public void TileHandle(Tile tile)
        {
            switch (tile.Type)
            {
                case TileType.Monster:
                    Battle(tile);
                    break;

                case TileType.Weapon:

                case TileType.Potion:
                    tile.Item?.ApplyEffect(Player);
                    LastMessage = tile.Item?.PickupMessage ?? "";
                    tile.Clear();
                    break;
                case TileType.Exit:
                    PlayerWin = true;
                    GameOver = true;
                    LastMessage = "You have escaped the maze!";
                    break;

            }
        }

        public void Battle(Tile tile)
        {
            var monster = tile.Monster;
            while (Player.IsAlive && monster.IsAlive)
            {
                monster.TakeDamage(Player.Attack());
                if (monster.IsAlive)
                {
                    Player.TakeDamage(monster.Attack());
                }
            }

            if (!Player.IsAlive)
            {
                GameOver = true;
                LastMessage = "You have died!";
            }
            else
            {
                LastMessage = "Monster Slain!";
                tile.Clear();
            }
        }
    } 
}

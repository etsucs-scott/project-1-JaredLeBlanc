using AdventureGame.Core.GameEngine;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core.DomainLogic
{
    public class Maze
    {
        public Tile[,] Grid { get; }

        public int Width { get; }
        public int Height { get; }

        Random random = new();

        public Maze(int width = 15, int height = 15)
        {
            Width = width;
            Height = height;
            
            Grid = new Tile[Width, Height];

            Generate();
        }

        public void Generate()
        {

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Grid[x, y] = new Tile(TileType.Empty);
                }
            }

            AddBorderWalls();

            // random walls
            for (int i = 0; i < 25; i++)
            {
                PlaceRandom(TileType.Wall);
            }
            // random monsters
            for (int i = 0; i < 5; i++)
            {
                int hp = random.Next(30, 50);
                var tile = PlaceRandom(TileType.Monster);
                tile.Monster = new Monster(hp);
            }
            // random weapons
            for (int i = 0; i < 3; i++)
            {
                var tile = PlaceRandom(TileType.Weapon);
                tile.Item = new Weapon("Sword", random.Next(5, 15));
            }
            // random potions
            for (int i = 0; i < 3; i++)
            {
                var tile = PlaceRandom(TileType.Potion);
                tile.Item = new Potion();
            }
            // random exit
            PlaceRandom(TileType.Exit);
        }

        public void AddBorderWalls()
        {
            for (int x = 0; x < Width; x++)
            {
                Grid[x, 0].Type = TileType.Wall;
                Grid[x, Height - 1].Type = TileType.Wall;
            }

            for (int y = 0; y < Height; y++)
            {
                Grid[0, y].Type = TileType.Wall;
                Grid[Width - 1, y].Type = TileType.Wall;
            }
        }

        public Tile PlaceRandom(TileType type)
        {
            int x, y;
            do
            {
                x = random.Next(1, Width -1);
                y = random.Next(1, Height -1);
            }
            while (Grid[x, y].Type != TileType.Empty
                || Grid[x,y].Monster != null
                || Grid[x,y].Item != null);

            Grid[x, y].Type = type;
            return Grid[x, y];
        }
    }
}

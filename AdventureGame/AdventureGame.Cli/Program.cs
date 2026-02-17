using AdventureGame.Core;
using AdventureGame.Core.DomainLogic;
using AdventureGame.Core.GameEngine;

namespace AdventureGame.Cli 
{
   class Program
    {
        static void Main()
        {
            var game = new GameEngine();

            while (!game.GameOver)
            {
                Console.Clear();
                Render(game);

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.W: game.Move(0, -1); break;
                    case ConsoleKey.S: game.Move(0, 1); break;
                    case ConsoleKey.A: game.Move(-1, 0); break;
                    case ConsoleKey.D: game.Move(1, 0); break;
                }
            }

            Console.Clear();
            Render(game);
            Console.WriteLine("\nGame Over!");
        }

        static void Render(GameEngine game)
        {
            Console.WriteLine(game.LastMessage);
            Console.WriteLine($"HP: {game.Player.Health}");
            Console.WriteLine();

            for (int y = 0; y < game.Maze.Height; y++)
            {
                for (int x = 0; x < game.Maze.Width; x++)
                {
                    
                    if (x == game.PlayerX && y == game.PlayerY)
                    {
                        Console.Write("@ ");
                        continue;
                    }

                    var tile = game.Maze.Grid[x, y];
                    char symbol = '.';

                    if (tile.Type == TileType.Wall)
                        symbol = '#';
                    else if (tile.Type == TileType.Exit)
                        symbol = 'E';
                    else if (tile.Monster != null)
                        symbol = 'M';
                    else if (tile.Item is Weapon)
                        symbol = 'W';
                    else if (tile.Item is Potion)
                        symbol = 'P';

                    Console.Write(symbol + " ");
                }

                Console.WriteLine();
            }
        }

    }

}
Build & Run

	git clone <https://github.com/etsucs-scott/project-1-JaredLeBlanc.git>
	cd AdventureGame
	dotnet build
	dotnet run --project AdventureGame.Cli

Controls:

	W = Up
	S = Down
	A = Left
	D = Right

Legend:

	@ = Player
	# = Wall
	. = Empty
	M = Monster
	W = Weapon
	P = Potion
	E = Exit

Maze Format:

	##########
	#@..#P..W#
	#...#..###
	#M###.#.P#
	#.w#..##.#
	#.###....#
	#...M.##.#
	#P######E#
	##########

Win/Lose Conditions:

	Win = Reach the Exit tile.
	Lose = Health reaches 0.

Battle Rules:
	
	Player Health = 100 at start.
	Monster Health is 30-50.
	Player always attacks first.
	Base damage of 10 + best weapon modifier.
	Monster attacks after player.
	Cycle is continued until player or monster dies.
	Not allowed to flee.

UML Diagram:

	FILE: 'Documents/AdventureGame_UML.png'
	The Diagram shows:
		- All core classes (Item, Maze, Monster, Player, Potion, Weapon, GameEngine, Etc.)
		- Inheritance relationships (Ex. Player --> ICharacter)
		- Fields/Properties and key methods.

Git Usage Notes:

	Clone:

	- git clone <https://github.com/etsucs-scott/project-1-JaredLeBlanc.git>

	Build:

	- dotnet build

	Run:

	- dotnet run --project AdventureGame.Cli

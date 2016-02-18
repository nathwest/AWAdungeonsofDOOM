using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AWAdungeonsofDOOM
{
    class Game
    {
        const int WorldWidth = 20;
        const int WorldHeight = 10;
        Player player;
        Room[,] world;
        public void Start()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Welcome to Superman vs Kanye West");
            Console.WriteLine("To be released Q3 2018");
            Console.WriteLine("Under development");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Input s for Start Game");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("For Epic tunes, press W/E:");
            Console.WriteLine("w for Starwars, e for random");
            Console.WriteLine("---------------------------------");
            var musik = Console.ReadKey();
            switch (musik.Key) //Switch on Key enum
            {
                case ConsoleKey.W:
                    StarWars();
                    break;
                case ConsoleKey.E:
                    StartMusic();
                    break;
                default:
                    break;
            }
                    //}
                    //if (musik == "w")
                    //{
                    //    StarWars();
                    //}
                    //else if (musik == "e")
                    //{
                    //    StartMusic();
                    //}
                    //else

                    CreateWorld();
                    CreatePlayer();
                    do
                    {
                        Console.Clear();
                        DisplayStats();
                        DisplayWorld();
                        AskForMovement();
                        player.Health--;
                    } while (player.Health > 0);

                    GameOver();
            }
        

        private void StarWars()
        {
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
        }

        private void StartMusic()
        {
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            Thread.Sleep(600);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 300);
            Console.Beep(440, 300);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(494, 300);
            Console.Beep(494, 100);
            Console.Beep(494, 100);
            Console.Beep(494, 300);
            Console.Beep(494, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(494, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 800);
        }


        private void EndScreen()
        {
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
        }

        private void DisplayStats()
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");

            int backpackWeight = 0;
            foreach (var item in player.BackPack)
            {
                backpackWeight += item.Weight;
            }
            Console.WriteLine($"Items in Backpack(weight {backpackWeight}/{player.LiftStrength}): ");
            foreach (var item in player.BackPack)
            {
                Console.Write($"{item.Name}({item.Weight}) | ");
            }
            Console.WriteLine();
            Console.WriteLine($"Pos: {player.X}:{player.Y}");
        }

        private void AskForMovement()
        {
            Console.WriteLine("Move!");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            int x = player.X;
            int y = player.Y;
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: x++; break;
                case ConsoleKey.LeftArrow: x--; break;
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y++; break;
            }


            if (x >= 0 && x < WorldWidth && y >= 0 && y < WorldHeight)
            {
                player.X = x;
                player.Y = y;
                if (world[x, y].MonsterInRoom != null)
                {
                    player.Health = 1;
                }
                if (world[x, y].ItemInRoom != null)
                {
                    int backpackWeight = 0;
                    foreach (var item in player.BackPack)
                    {
                        backpackWeight += item.Weight;
                    }

                    if (player.LiftStrength >= (world[x, y].ItemInRoom.Weight + backpackWeight))
                    {
                        PickUpChoice(x, y);

                    }
                }
            }
        }

        private void PickUpChoice(int x, int y)
        {

            Console.WriteLine($"Do you want to pick up the {world[x, y].ItemInRoom.Name}? Y/N");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                player.BackPack.Add(world[x, y].ItemInRoom);
                world[x, y].ItemInRoom = null;
            }

        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over. Massive Disaster.");
            Console.WriteLine("We all know Superman can't die");
            EndScreen();
            Console.ReadKey();
        }

        private void CreateWorld()
        {
            world = new Room[WorldWidth, WorldHeight];
            for (int y = 0; y < WorldHeight; y++)
            {
                for (int x = 0; x < WorldWidth; x++)
                {
                    Room room = new Room();
                    world[x, y] = room;
                }
            }

            // Placera ut monster
            world[2, 2].MonsterInRoom = new Monster("Kayne West 3", 30, 10);
            world[8, 8].MonsterInRoom = new Monster("Kayne West", 25, 15);
            world[15, 4].MonsterInRoom = new Monster("Kayne West 2", 75, 5);

            // placera ut item

            world[4, 4].ItemInRoom = new Item("Super Diamond", 3);
            world[3, 6].ItemInRoom = new Item("Biggest Sapphire", 3);
            world[6, 1].ItemInRoom = new Item("Epic Stone", 5);
        }

        private void CreatePlayer()
        {
            player = new Player("Kal El", 100, 20, 10);
        }

        private void DisplayWorld()
        {
            {
                for (int y = 0; y < WorldHeight; y++)
                {
                    for (int x = 0; x < WorldWidth; x++)
                    {
                        Room room = world[x, y];

                        if (player.X == x && player.Y == y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write('$');
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else if (room.MonsterInRoom != null)
                        {
                            Monster monster = room.MonsterInRoom;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write('ö');
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else if (room.ItemInRoom != null)
                        {
                            Item item = room.ItemInRoom;
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Write('¤');
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Write('.');
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}
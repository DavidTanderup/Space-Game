using System;
using System.Collections.Generic;


public class Resources
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Value { get; set; }
    public int Size { get; set; }

}

namespace ConsoleApp4
{


    /// <summary>
    /// Represents Map Coordinate
    /// </summary>

    //    class Coordinate
    //    {

    //    public int X { get; set; } //Left
    //    public int Y { get; set; } //Top
    //}



    class Movement
    {
        const ConsoleColor HERO_COLOR = ConsoleColor.Black;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Black;

        public static Coordinate Hero { get; set; } /// our fearless hero




        public void MovementMain(Ships.SpaceShip someShip, double Distance, double Speed) //list of asteroid?? mySpaceShip will be passed
        {
            Asteroids ast = new Asteroids();
            InitGame(someShip.rep);
            int width = Console.WindowWidth-1;
            int height = Console.WindowHeight;
            List<Coordinate> AsteroidList = new List<Coordinate> { };
            for(int i = 0; i < width / 2; i++)
            {
                AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                ast.AsteroidMover(AsteroidList);
            }

            bool alive = true;
            ConsoleKeyInfo keyInfo;
            int CycleCounter = 0;

            while (alive)
            {
                if (CycleCounter == 50)
                {
                ast.AsteroidMover(AsteroidList);
                AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                    CycleCounter = 0;
                }   
                System.Threading.Thread.Sleep(5);
                CycleCounter++;

                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            MoveHero(0, -1, someShip.rep);
                            break;

                        case ConsoleKey.RightArrow:
                            MoveHero(1, 0, someShip.rep);
                            break;

                        case ConsoleKey.DownArrow:
                            MoveHero(0, 1, someShip.rep);
                            break;

                        case ConsoleKey.LeftArrow:
                            MoveHero(-1, 0, someShip.rep);
                            break;

                        case ConsoleKey.Spacebar:
                            AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                            break;

                    }
                }

            foreach (Coordinate asteroidCoor in AsteroidList)
            {
                if ((asteroidCoor.X >= Hero.X && asteroidCoor.X <= Hero.X + someShip.rep.Length) && asteroidCoor.Y == Hero.Y)
                {
                    alive = false;
                }
            }
            }
        }



        private void MoveHero(int x, int y, string spaceship)
        {

            Coordinate newHero = new Coordinate()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero(spaceship);

                Console.BackgroundColor = HERO_COLOR;
                Console.SetCursorPosition(newHero.X, newHero.Y);
                Console.Write(spaceship);
                Console.WriteLine();

                Hero = newHero;
            }


        }

        private void RemoveHero(string spaceship)
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(XSpaces(spaceship.Length));

        }

        private bool CanMove(Coordinate c)
        {
            if (c.X < 0 || c.X >= Console.WindowWidth)
            {
                return false;
            }
            if (c.Y < 0 || c.Y >= Console.WindowHeight)
            {
                return false;
            }

            return true;
        }


        private void SetBackGroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear();
        }

        /// <summary>
        /// Initiates game by painting background 
        /// and iniating the hero
        /// </summary>

        private void InitGame(string spaceship)
        {
            SetBackGroundColor();

            Hero = new Coordinate()
            {
                X = 0,
                Y = 0
            };

            MoveHero(0, 0, spaceship);
        }



        private string XSpaces(int cursorPos)  //don't forget about me if you want several levels
        {
            string spaces = "";
            for (int i = 0; i < cursorPos; i++)
            {
                spaces += ' ';
            }
            return spaces;
        }



    }






}


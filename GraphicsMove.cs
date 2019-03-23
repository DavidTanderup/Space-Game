using System;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace SpaceCadets
{


    /// <summary>
    /// Represents Map Coordinate
    /// </summary>

    class Coordinate
    {

        public int X { get; set; } //Left
        public int Y { get; set; } //Top
    }



    class Movement
    {
        const ConsoleColor HERO_COLOR = ConsoleColor.Black;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Black;

        public static Coordinate Hero { get; set; } /// our fearless hero




        public void MovementMain(SpaceCadets.Characters self , double Distance, double Speed) //list of asteroid?? mySpaceShip will be passed
        {
            bool alive = true;
            Asteroids ast = new Asteroids();
            InitGame(self.mySpaceShip.rep);
            int width = Console.WindowWidth-1;
            int height = Console.WindowHeight;
            List<Coordinate> AsteroidList = new List<Coordinate> { };
            for(int i = 0; i < width / 2; i++)
            {
                AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                ast.AsteroidMover(AsteroidList);
            }
            ConsoleKeyInfo keyInfo;
            int CycleCounter = 0;
            double refreshVar = 50/Speed;
            int timeLength = 2 *  Convert.ToInt32(Math.Round(Distance)*200); //200 * 5ms per loop = ceiling counter
            int timeCounter = 0;

            {
                while (alive && timeCounter<timeLength)
                {
                    if (CycleCounter == refreshVar)
                    {
                        ast.AsteroidMover(AsteroidList);
                        AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                        CycleCounter = 0;
                    }
                    System.Threading.Thread.Sleep(5);
                    CycleCounter++;
                    timeCounter++;

                    if (Console.KeyAvailable)
                    {
                        keyInfo = Console.ReadKey(true);
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                MoveHero(0, -1, self.mySpaceShip.rep);
                                break;

                            case ConsoleKey.RightArrow:
                                MoveHero(1, 0, self.mySpaceShip.rep);
                                break;

                            case ConsoleKey.DownArrow:
                                MoveHero(0, 1, self.mySpaceShip.rep);
                                break;

                            case ConsoleKey.LeftArrow:
                                MoveHero(-1, 0, self.mySpaceShip.rep);
                                break;

                            case ConsoleKey.Spacebar:
                                AsteroidList.Insert(AsteroidList.Count, ast.spawnAsteroid(width, height));
                                break;

                        }
                    }

                    foreach (Coordinate asteroidCoor in AsteroidList)
                    {
                        if ((asteroidCoor.X >= Hero.X && asteroidCoor.X <= Hero.X + self.mySpaceShip.rep.Length) && asteroidCoor.Y == Hero.Y)
                        {
                            alive = false;
                        }
                    }
                }
            }
            Console.Clear();
            Console.SetCursorPosition(height, width);
            if (alive == true)
            {
                Formulas form = new Formulas();
                SpaceCadets.Menus menu = new SpaceCadets.Menus();
                double tripTime = Distance / form.WarpSpeed(Speed);
                self.mySpaceShip.fuel.weight -= Distance * 100;
                self.Age += tripTime;
                menu.MainMenu(self);

            }
            else if (alive == false)
            {
                Console.Clear();
                YouLostButNotReally();
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

        private static System.Timers.Timer aTimer;

        private void Timer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += TimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

        public void YouLostButNotReally()
        {
            Timer();

            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
            Console.Clear();
        }

        private void TimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("", e);
            Console.ForegroundColor = ConsoleColor.Red;
            YouAreDead();
            Thread.Sleep(1200);

            Console.ForegroundColor = ConsoleColor.White;
            YouAreDead();
            Thread.Sleep(1200);

            Console.ForegroundColor = ConsoleColor.Blue;
            YouAreDead();

        }

        private void YouAreDead()
        {

            string logo = "YOU ARE DEAD!!!!! I told you that you would die!!!";
            Console.Clear();
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo.Length / 2), Console.LargestWindowHeight/2);
            Console.WriteLine(logo);
        }


    }






}


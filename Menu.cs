using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceCadets
{
    class Menus
    {
        public void MainMenu(Characters self)
        {
            Console.Clear();            
            Console.SetCursorPosition(Console.LargestWindowWidth/3, 0);
            Console.WriteLine($"You are {self.Age} years old at the planet {self.location.PlanetName}");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, 2);
            Console.WriteLine($"You've got about {self.mySpaceShip.fuel.weight / 100}  LY of fuel.");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, 4);
            Console.WriteLine("T- Travel S-Trade");
            while (true)
            {
                ConsoleKeyInfo keyInfo;
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.T:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\tYou have chosen to travel");
                            Thread.Sleep(2000);
                            Console.WriteLine("\t\t\n\nIt's a dangerous business, Frodo, going out your door. You step onto the road, and if you don't keep your feet, there's no knowing where you might be swept off to");
                            Thread.Sleep(4000);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\n[Janet] I just love when you quote JRR Tolkien");
                            Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t\n You say that EVERYTIME.");
                            Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\n[Janet] I know");
                            Thread.Sleep(2000);
                            Console.WriteLine("\t\t\n...but you should have written the program better.");
                            Thread.Sleep(5000);
                            Console.Clear();
                            TravelMenu(self);
                            break;

                        case ConsoleKey.S:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("trade");
                            MarketPlace marketPlace = new MarketPlace();
                            MarketResources thing = new MarketResources();
                            var list = thing.MarketGenerate(self);
                            marketPlace.InTheMarketPlace(self, list);


                            break;

                        
                    }
                }
            }

        }




        private static void TravelMenu(Characters self)
        {
            Formulas form = new Formulas();
            Planet planets = new Planet();
            var galaxy = planets.PlanetSystem();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\nWhere would you like to travel?");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\n[Janet] OOOOOO I have always wanted to go to....");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\nJanet!!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\n[Janet] Sorry");
            Thread.Sleep(5000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\nWhere would you like to travel?\n");

            for (int i = 0; i < galaxy.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{i}. {galaxy[i].PlanetName}");
            }

            bool success = false;
            while (!success)
            {
                Console.WriteLine();
                success = int.TryParse(Console.ReadLine(), out int input);

                if (success == true && input >= 0 && input < galaxy.Count)
                {
                    Menus menu = new Menus();
                    Planet targetPlanet = galaxy[input];
                    success = true;
                    menu.TravelPlanetPrompt(self, targetPlanet);
                }

                else
                {
                    Console.Clear();
                    TravelMenu(self);
                }
            }                            
        }




        public void TravelPlanetPrompt(Characters self, Planet toPlanet)
        {
            Formulas form = new Formulas();
            double distanceToPlanet = form.Dist2Points(self.location.PlanetCoordinate, toPlanet.PlanetCoordinate);
            Console.WriteLine($"Your max speed is {form.WarpSpeed(self.mySpaceShip.engines.speed)}");
            Console.Write($"Please enter a speed between zero and {self.mySpaceShip.engines.speed}: ");
            bool isValidSpeed = double.TryParse(Console.ReadLine(), out double selectedSpeed);

            if(isValidSpeed && selectedSpeed>0 && selectedSpeed <= self.mySpaceShip.engines.speed)
            {

                Console.WriteLine($"Your trip to {toPlanet.PlanetName} will take approximately {form.TravelTime(selectedSpeed, distanceToPlanet)} years\nDo you accept?");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n[Janet] Press 'Y' for yes or 'N'....please pick yes");
                ConsoleKeyInfo option = new ConsoleKeyInfo();
                bool valid = true;
                Movement game = new Movement();

                while(valid)
                {
                    option = Console.ReadKey();
                    switch(option.Key)
                    {
                        case ConsoleKey.Y:
                            self.location = toPlanet;
                            game.MovementMain(self, distanceToPlanet, selectedSpeed);
                            MarketResources item = new MarketResources();
                            item.MarketGenerate(self);
                            valid = false;
                            break;

                        case ConsoleKey.N:
                            Console.Clear();
                            TravelMenu(self);
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
            }

     





        }
    }
}

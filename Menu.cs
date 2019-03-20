using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace SpaceCadets
{
    class Menus
    {
        public void MainMenu(Characters self)
        {
            Console.WriteLine($"You are {self.Age} years old at the planet {self.location.PlanetName}");
            Console.WriteLine("T- Travel, S-Trade, M-Mine");
            while (true)
            {
                ConsoleKeyInfo keyInfo;
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.T:
                            Console.WriteLine("travel");
                            TravelMenu(self);
                            break;

                        case ConsoleKey.S:
                            Console.WriteLine("trade");
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("mine");
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
            Console.WriteLine("Where would you like to travel?");
            for (int i = 0; i < galaxy.Count; i++)
            {
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
            Console.WriteLine($"Your max speed is {form.WarpSpeed(self.mySpaceShip.speed)}");
            Console.WriteLine($"Please enter a speed between zero and {self.mySpaceShip.speed}");
            bool isValidSpeed = double.TryParse(Console.ReadLine(), out double selectedSpeed);

            if(isValidSpeed && selectedSpeed>0 && selectedSpeed <= self.mySpaceShip.speed)
            {

                Console.WriteLine($"Your trip to {toPlanet.PlanetName} will take approximately {form.TravelTime(selectedSpeed, distanceToPlanet)} years\nDo you accept?");
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

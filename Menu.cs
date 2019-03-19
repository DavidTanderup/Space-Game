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


        //ConsoleKeyInfo action;
        public void MainMenu(Characters self)
        {
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
                //int input;
                Console.WriteLine($"{i}. {galaxy[i].PlanetName}");
            }

            bool success = false;
            while (!success)
            {
                Console.WriteLine();
                success = int.TryParse(Console.ReadLine(), out int input);
                try
                {
                    Console.WriteLine($"Would you like to go to {galaxy[input].PlanetName}?");                   
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter a planet from the list!");
                    TravelMenu(self);
                }
                Planet targetPLanet = galaxy[input];
                bool correct = false;
                while (!correct)
                {
                    char option = char.Parse(Console.ReadLine());
                    //switch (option)
                    //{
                    //    case 'y':
                    //        TravelPlanetPrompt(self, targetPLanet);
                    //        break;


                    //    case 'n':


                    //}






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

                Console.WriteLine($"Your trip will take approximately {form.TravelTime(selectedSpeed, distanceToPlanet)} years");
            }

            else
            {
                TravelPlanetPrompt(self, toPlanet);
            }





        }
    }
}

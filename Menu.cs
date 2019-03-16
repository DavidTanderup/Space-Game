using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    class Menus
    {

        //ConsoleKeyInfo action;
        public void MainMenu()
        {
            while (true)
            {
                //switch (action.Key) //Travel, Trade, Fuel, Mine
                //{
                //    case ConsoleKey.UpArrow:
                //        Console.WriteLine("up");
                //        System.Threading.Thread.Sleep(1000);
                //        break;

                //    case ConsoleKey.DownArrow:
                //        Console.WriteLine("down");
                //        break;

                //    case ConsoleKey.RightArrow:
                //        Console.WriteLine("right");
                //        break;

                //}



                ConsoleKeyInfo keyInfo;
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.T:
                            Console.WriteLine("travel");
                            TravelMenu();
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

        private static void TravelMenu()
        {
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
            }    

               


        }

            
        
    }
}

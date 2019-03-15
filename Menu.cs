using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    class Menus
    {

        ConsoleKeyInfo action;
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
                        case ConsoleKey.UpArrow:
                            Console.WriteLine("up");                        //KeyPress = true;
                            break;

                        case ConsoleKey.RightArrow:
                            Console.WriteLine("something");                            //KeyPress = true;
                            break;

                        case ConsoleKey.DownArrow:
                            Console.WriteLine("something");                            //KeyPress = true;
                            break;
                    }
                }
            }

        }
    }
}

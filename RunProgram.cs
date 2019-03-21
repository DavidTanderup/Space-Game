using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceCadets
{
    class RunProgram
    {
        public void Run()
        {
            Console.SetCursorPosition(Console.LargestWindowWidth / 2, 5);
            GameWelcome();
            PlayerInfo();
            MarketPlace marketPlace = new MarketPlace();
            marketPlace.InTheMarketPlace();
        }

        private List<string> StarTader()
        {
            string starTrader1 = "SSSSSSSS   TTTTTTTT    AAAAAA    RRRRRRR      TTTTTTTT   RRRRRRR     AAAAAA    DDDDDDD    EEEEEEEE   RRRRRRR\n";
            string starTrader2 = "S             TT      AA    AA   RR    RR        TT      RR    RR   AA    AA   DD    DD   EE         RR    RR\n";
            string starTrader3 = "SSSSSSSS      TT      AAAAAAAA   RRRRRRRR        TT      RRRRRRRR   AAAAAAAA   DD    DD   EEEEEEEE   RRRRRRRR\n";
            string starTrader4 = "       S      TT      AA    AA   RR   RR         TT      RR   RR    AA    AA   DD    DD   EE         RR   RR";
            string starTrader5 = "SSSSSSSS      TT      AA    AA   RR    RR        TT      RR    RR   AA    AA   DDDDDDD    EEEEEEEE   RR    RR";
            string starTrader6 = "\n\n                                                                                                                                   ";
            string starTrader7 = "\n                                                                                            Press Enter to Continue";
            List<string> welcome = new List<string>() { starTrader1, starTrader2, starTrader3, starTrader4, starTrader5, starTrader7, starTrader6 };
            return welcome;

        }
        public void GameWelcome()
        {
            Thread.Sleep(1200);
            var title = StarTader();
            int counter = 4;
            int i = 5;
            int j = 0;
            while (counter>= 0)
            {

                for (j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (title[2].Length / 2), i);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(title[j]);
                    i++;
                }
                i = 5;
                Thread.Sleep(1200);
                Console.Clear();

                for (j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (title[2].Length / 2), i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(title[j]);
                    i++;
                }

                i = 5;
                Thread.Sleep(1200);
                Console.Clear();

                for (j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (title[2].Length / 2), i);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(title[j]);
                    i++;
                }
               
                i = 5;
                Thread.Sleep(1200);
                Console.Clear();

                counter--;

            }


        }

        public void PlayerInfo()
        {
            Console.WriteLine("Welcome to Space Trader");
            Console.WriteLine("=======================");
            Console.WriteLine("\nA Game where the points are made up and the rules don't matter.");
            Thread.Sleep(3000);
            Console.WriteLine("\n[Janet] 'Unless you die'");
            Thread.Sleep(1500);
            Console.WriteLine("\nThanks Janet...yes unless you die or you play games to win, in which case I wouldn't play this game,\n" +
                              "because you will not win. Ever");
            Thread.Sleep(3500);
            Console.WriteLine("\n[Janet] 'Unless they do'");
            Thread.Sleep(1700);
            Console.WriteLine("\nObviously...");
            Thread.Sleep(1250);
            Console.WriteLine("Waiting for another cheeky remark from Janet?");
            Thread.Sleep(1400);
            Console.WriteLine("I have a riddle for you");

            bool pete = true;
            while (pete)
            {
                Console.Clear();
                Console.WriteLine("Pete and Repeat were on a boat Pete fell off. Who was left?\n");
                Console.WriteLine("1)Pete");
                Console.WriteLine("2)Repeat");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("You are truly boring");
                        Console.WriteLine("[Janet] 'That was a smart choice dear'");
                        pete = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("You are truly boring");
                        Console.WriteLine("[Janet] 'That was a smart choice dear'");
                        
                        pete = false;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Thread.Sleep(2000);
                        pete = true;
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Thread.Sleep(2000);
                        pete = true;
                        break;

                }

            }

        }




    }
}

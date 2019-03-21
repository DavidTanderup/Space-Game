using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace SpaceCadets
{
    class RunProgram
    {
        public void Run()
        {
            MarketPlace marketPlace = new MarketPlace();
            Console.SetCursorPosition(Console.LargestWindowWidth / 2, 5);
            PrettyColors();
            Console.Clear();
            PlayerInfo();
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

        private static System.Timers.Timer aTimer;

        private void Timer ()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += TimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

        public void PrettyColors()
        {
            Timer();

            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
            Console.Clear();
        }

        private void TimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("",e);
            Console.ForegroundColor = ConsoleColor.Red;
            Logo();
            Thread.Sleep(1200);

            Console.ForegroundColor = ConsoleColor.White;
            Logo();
            Thread.Sleep(1200);

            Console.ForegroundColor = ConsoleColor.Blue;
            Logo();
                       
        }

        private void Logo()
        {
            
            var logo = StarTader();
            Console.Clear();
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 5);
            Console.WriteLine(logo[0]);
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 6);
            Console.WriteLine(logo[1]);
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 7);
            Console.WriteLine(logo[2]);
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 8);
            Console.WriteLine(logo[3]);
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 9);
            Console.WriteLine(logo[4]);
            Console.SetCursorPosition((Console.LargestWindowWidth / 2) - (logo[2].Length / 2), 12);
            Console.WriteLine("\n\n\n\n                                                                                        Press Enter to Continue");
        }

        public void PlayerInfo()
        {
            Console.Clear();
            Thread.Sleep(4000);
            Console.WriteLine("\t\tWelcome to Space Trader");
            Console.WriteLine("\t\t=======================");
            Console.WriteLine("\t\t\nA Game where the points are made up and the rules don't matter.");
            Thread.Sleep(4000);
            Console.WriteLine("\t\t\n[Janet] 'Unless you die'");
            Thread.Sleep(2500);
            Console.WriteLine("\t\t\nThanks Janet...yes unless you die or you play games to win, in which case I wouldn't play this game,\n" +
                              "\t\tbecause you will not win. Ever");
            Thread.Sleep(4500);
            Console.WriteLine("\t\t\n[Janet] 'Unless they do'");
            Thread.Sleep(2700);
            Console.WriteLine("\t\t\nObviously...");
            Thread.Sleep(2250);
            Console.WriteLine("\t\tWaiting for another cheeky remark from Janet?");
            Thread.Sleep(2400);
            Console.WriteLine("\t\tI have a riddle for you");

            bool pete = true;
            while (pete)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\tPete and Repeat were on a boat Pete fell off. Who was left?\n");
                Console.WriteLine("\t\t1)Pete");
                Console.WriteLine("\t\t2)Repeat");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\t\tYou are truly boring");
                        Console.WriteLine("\t\t[Janet] 'That was a smart choice dear'");
                        Thread.Sleep(2000);
                        pete = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("\t\tYou are truly boring");
                        Console.WriteLine("\t\t[Janet] 'That was a smart choice dear'");
                        Thread.Sleep(2000);
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

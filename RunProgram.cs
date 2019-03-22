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
            Planet planet = new Planet();
            var planetList = planet.PlanetSystem();

            MarketResources MarsBars = new MarketResources(planetList[0], "Mars Bars", 250);
            MarketResources SunScreen = new MarketResources(planetList[0], "Sun Screen", 1); /// TODO: 42 sold on earth will give $500,000
            MarketResources MoonPies = new MarketResources(planetList[1], "Moon Pies", 200);
            MarketResources Honey = new MarketResources(planetList[2], "Honey [sourced by local Proxima Bees]", 500);
            MarketResources Kryptonite = new MarketResources(planetList[3], "Kryptonite", 15000);
            MarketResources Widgets = new MarketResources(planetList[4], "Widget", 800);
            MarketResources BugSpray = new MarketResources(planetList[5], "Bug Spray by K", 486);
            MarketResources ZombieRepellent = new MarketResources(planetList[6], "Zombie Repellent", 7200);
            (MarketResources resource, int quantity)[] inventory =
            {(MarsBars, 0), (SunScreen, 0), (MoonPies, 0), (Honey, 0), (Kryptonite, 0), (Widgets, 0), (BugSpray, 0), (ZombieRepellent, 0)};

            //SpaceShip spaceShip = new SpaceShip();
            SpaceShip SpaceShipOptions = new SpaceShip();

            Engines myEngine = SpaceShipOptions.Engine3;
            Fuel myFuel = SpaceShipOptions.Fuel3;
            Cargo myCargo = SpaceShipOptions.Cargo3;

            SpaceShip spaceShip = new SpaceShip(myEngine, myFuel, myCargo);

            Characters PlayerOne = new Characters(5000, 20, planetList[1], "Bob",spaceShip, true, inventory);

            MarketPlace marketPlace = new MarketPlace();
            Console.SetCursorPosition(Console.LargestWindowWidth / 2, 5);
            MarketResources thing = new MarketResources();
            var list = thing.MarketGenerate(PlayerOne);
           // PrettyColors();// 
            Console.Clear();
           // PlayerInfo();
           // SoloShipShopIntro(PlayerOne);
            
            /// insert information co
            
            marketPlace.InTheMarketPlace(PlayerOne, list);
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

        private void Timer()
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
            Console.WriteLine("", e);
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

        /// <summary>
        /// TODO: add player information collection
        /// </summary>
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

        public void SoloShipShop(Characters self)
        {
            MoonMarket moonMarket = new MoonMarket();
            Dialogue dialogue = new Dialogue();
            bool stillHere = true; /// while the player is in the ship market
            while (stillHere)
            {

                Console.Clear();
                SoloTitle();
                dialogue.ShipShopIntro_EverTimeAfter();

                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        moonMarket.moonMarketMenu(self);
                        Console.ReadLine();
                        stillHere = true;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        moonMarket.moonMarketMenu(self);
                        Console.ReadLine();
                        stillHere = true;
                        break;
                    case ConsoleKey.D2:
                        stillHere = true;
                        Console.Clear();
                        dialogue.SolosSweetStory();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.NumPad2:
                        stillHere = true;
                        Console.Clear();
                        dialogue.SolosSweetStory();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("\t\t\n\nYou have left Solo's Ship Shop #spaceboats");
                        Console.ReadLine();
                        stillHere = false;
                        break;

                }




                /// TODO: create the standard solo interface
            }
        }



        public void SoloShipShopIntro(Characters self)
        {
            MoonMarket moonMarket = new MoonMarket();
            Dialogue dialogue = new Dialogue();
            SoloTitle();
            dialogue.S3_JanetIntro();
            Thread.Sleep(2000);
            bool stillHere = true; /// while the player is in the ship market
            while (stillHere)
            {

                Console.Clear();
                SoloTitle();
                dialogue.ShipShopIntro_First();

                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("You are now the proud new owner of a:\n");
                        Console.ReadLine();
                        stillHere = true;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("You bought a ship!!");
                        Console.ReadLine();
                        stillHere = true;
                        break;
                    case ConsoleKey.D2:
                        stillHere = true;
                        Console.Clear();
                        dialogue.SolosSweetStory();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.NumPad2:
                        stillHere = true;
                        Console.Clear();
                        dialogue.SolosSweetStory();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("\t\t\n\nYou have left Solo's Ship Shop #spaceboats");
                        Console.ReadLine();
                        stillHere = false;
                        break;

                }
            }



        }

        private void SoloTitle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tSOLO SHIP SHOP [Location: Moon]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t===============================");
            Console.WriteLine("\t\t\n\n");
        }


    }

    public class Dialogue
    {
        /// <summary>
        /// The first time through the loop Janet and R2D2 break the fourth wall. This method will only
        /// play once. 
        /// </summary>
        public void S3_JanetIntro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tThe shop is a dusty old relic that has seen better days, but since it's the only game in town it looks like you are stuck here.\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(3500);
            Console.WriteLine("\t\t[Janet] You've seen better days too, but you don't see anyone complaining about a cantankerous " +
                                   "battle droid that has been relegated to running a two bit video game\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(2500);
            Console.WriteLine("\t\t....");
            Thread.Sleep(2500);
            Console.WriteLine("\t\t....");
            Thread.Sleep(2500);
            Console.WriteLine("\t\t....");
            Thread.Sleep(2500);
            Console.WriteLine("\t\tAre you done?\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(2500);
            Console.WriteLine("\t\t[Janet] Yes, I'm sorry you were doing very well. I'm just very excited someone is playing your game.");
            Thread.Sleep(2500);
        }

        /// <summary>
        /// The Intro_first is the first time the user visit's solo ship shop.
        /// </summary>
        public void ShipShopIntro_First()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tWalking into the prestigious shop of the famed trader and part time Hero Hans Solo, you see the seasoned gentleman leaning on the counter.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tWelcome friend what can I do for you today?");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\t\t1) I'd like to buy a ship");
            Console.WriteLine("\n\t\t2) What's all the commotion going on outside?");
            Console.WriteLine("\n\n\t\tExit [Escape Key]");
        }

        /// <summary>
        /// The intro for Solo's Ship Shop when the user re-visits. The menu selection is changed to upgrade ship and
        /// selecting that option takes you to the moonmarket upgrade station.
        /// </summary>
        public void ShipShopIntro_EverTimeAfter()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tWalking into the prestigious shop of the famed trader and part time Hero Hans Solo, you see the seasoned gentleman leaning on the counter.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tWelcome friend what can I do for you today?");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\t\t1) I'd like to upgrade a ship");
            Console.WriteLine("\n\t\t2) What's all the commotion going on outside?");
            Console.WriteLine("\n\n\t\tExit [Escape Key]");
        }

        /// <summary>
        /// The story Hans Solo tell when asked whats going on outside.
        /// </summary>
        public void SolosSweetStory()
        {
            string firstLine = ("The year is 3019 and Earth is celebrating the 100th anniversary of joining");
            string secondLine = "The Universal Unification of the United Union for the Unequivocal Understanding or U5";
            string thirdLine = "as we call it here on Earth. It’s a dumb name but we didn’t come up with it.";
            string fourthLine = "Besides we have been told that the true majesty of the name is lost when translated";
            string fifthLine = "from the Paladin language. The Paladins are the oldest and most advanced civilization"; 
            string sixthLine = "in the Galaxy… or so they claim. I mean seriously, it’s easy to say whatever you want";
            string seventhLine = "when no one can disprove what you say. We learned about 50 years ago that the Paladins";
            string eighthLine = "merged several time lines to create this one.Alternate realities are common knowledge now,";
            string ninthLine = "but before we met the U5 thought we were alone in the galaxy and that the Fantasy and";
            string tenthLine = "Sci - Fi stories and movies were works of imagination.We know now that they are products";
            string eleventhLine = "of individuals being able to see into another timeline.";


            List<string> solosSweetStory = new List<string>() {firstLine,secondLine,thirdLine,fourthLine,
                                                               fifthLine,sixthLine,seventhLine,eighthLine,
                                                               ninthLine,tenthLine,eleventhLine };
            int i = 0; /// The current list line.
            foreach (var item in solosSweetStory)
            {
                Console.SetCursorPosition(Console.LargestWindowWidth / 2-solosSweetStory[8].Length/2, 10 + i);
                Console.WriteLine(item);
                Thread.Sleep(3000);
                i++;
            }
            
        }
    }

   



   
}

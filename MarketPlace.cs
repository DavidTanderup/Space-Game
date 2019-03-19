using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceCadets
{
    class MarketPlace
    {
        public void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tWelcome to the Market"); /// TODO: add something with more imagination later
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====================================================\n\n");
        }
        public void ChoiceMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tYou can do one of four things:\n" +
                              "\n\t1) Buy Something" +
                              "\n\t2) Sell Something" +
                              "\n\t3) Stand around and be ackward" +
                              "\n\t4) Leave -- although technically you aren't doing that HERE, ");
            Console.WriteLine("\t            it's more of a transitory process that begins here,");
            Console.WriteLine("\t            but if you do choose that option know that we are excited");
            Console.WriteLine("\t            excited to be the start of that new journey in your life.");
            Thread.Sleep(5000);
            Console.Clear();
            Greeting();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tYou can do one of three things:\n" +
                  "\n\t1) Buy Something" +
                  "\n\t2) Sell Something" +
                  "\n\t3) Leave [Escape Key]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");
            MarketChoices();
        }

        private void MarketChoices()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            /// TODO: Add methods to 
            switch (userInput.Key)
            {
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    BuyMenu();
                    break;

                case ConsoleKey.D1:
                    Console.Clear();
                    BuyMenu();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Sell Things");
                    break;

                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.WriteLine("Sell Things");
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Exit");

                    break;


            }
        }

        public void BuyMenu()
        {
            /// TODO: Create seperate Method for buy generator
            /// TODO: Create the INT qty generator
            Random random = new Random();

            double marsBarsPrice = random.Next(100, 500);
            int marBarsQty = random.Next();
            double moonPiePrice = random.Next(500, 1000);
            double bugSprayPrice = random.Next();
            double widgetsPrice = random.Next();
            double kryptonite = random.Next();
            double honeyPrice = random.Next();
            double zombieRepellentPrice = random.Next();

            List<Tuple<string, int, double>> ThingsForSale = new List<Tuple<string,int,double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty ,marsBarsPrice),
                                                                                            new Tuple<string,int,double>("Moon Pies", ,moonPiePrice),
                                                                                            new Tuple<string,int,double>("Bug Spray", ,bugSprayPrice),
                                                                                            new Tuple<string,int,double>("Widgets", ,widgetsPrice),
                                                                                            new Tuple<string,int,double>("Kryptonite", ,kryptonite),
                                                                                            new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",,honeyPrice),
                                                                                            new Tuple<string,int,double>("Zombie Repellent", ,zombieRepellentPrice)};




            int firstItem = random.Next(0, 6);
            int firstQuanity = random.Next(1, 500);

            int secondItem = random.Next(0, 6);
            int secondQuanity = random.Next(1, 500);

            int thirdItem = random.Next(0, 6);
            int thirdQuantity = random.Next(1, 500);

            int fourthItem = random.Next(0, 6);
            int fourthQuantity = random.Next(1, 500);



            Console.WriteLine("Here are the things I have for sale.\n\n");
            Console.WriteLine($"Item: {ThingsForSale[firstItem].Item1} // Quantity: {firstQuanity}");
            Console.WriteLine($"{ThingsForSale[secondItem].Item1} Quantity: {secondQuanity}");
            Console.WriteLine($"{ThingsForSale[thirdItem].Item1} Quantity: {thirdQuantity}");
            Console.WriteLine($"{ThingsForSale[fourthItem].Item1} Quantity: {fourthQuantity}");













        }

        public void SellMenu()
        {

        }
        public void InTheMarket()
        {
            /// place the buy sell generators outside of the while loop. create an instance of the list
            /// inside the loop. Theory is that the list will not change until the player quits. The list however can be updated to reflect purchases
            bool inTheMarket = true;
            while (inTheMarket)
            {

                ChoiceMenu();
                /// Buy Menu Method

                /// Sell Menu Method





            }


        }

    }
}

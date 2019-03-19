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
        private void Greeting()
        {
            string i = "Welcome to the Market";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(i); /// TODO: add something with more imagination later
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====================================================\n\n");
        }

        private void FirstMenu()
        {
            Greeting();
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
        }

        private void SecondMenu()
        {
            
            Greeting();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tYou can do one of three things:\n" +
                  "\n\t1) Buy Something" +
                  "\n\t2) Sell Something" +
                  "\n\t3) Leave [Escape Key]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");


        }

        private (int, int, int, int, List<Tuple<string, int, double>>) InventoryGeneratorBuy()
        {
            Random random = new Random();

            double marsBarsPrice1 = random.Next(100, 500);
            double moonPiePrice1 = random.Next(500, 1000);
            double bugSprayPrice1 = random.Next(25, 100);
            double widgetsPrice1 = random.Next(300, 1600);
            double kryptonitePrice1 = random.Next(5000, 18000);
            double honeyPrice1 = random.Next(1, 60);
            double zombieRepellentPrice1 = random.Next(1000, 22000);
            double sunScreenPrice1 = random.Next(15, 365);

            int marBarsQty1 = random.Next(100, 500);
            int moonPieQty1 = random.Next(1, 1000);
            int bugSprayQty1 = random.Next(1, 1500);
            int widgetsQty1 = random.Next(500, 850);
            int kryptoniteQty1 = random.Next(6, 87);
            int honeyQty1 = random.Next(1000, 100000);
            int zombieRepellentQty1 = random.Next(1, 100);
            int sunScreenQty1 = random.Next(15, 8200);

            List<Tuple<string, int, double>> ThingsToBuy = new List<Tuple<string, int, double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty1 ,marsBarsPrice1),
                                                                                            new Tuple<string,int,double>("Moon Pies",moonPieQty1 ,moonPiePrice1),
                                                                                            new Tuple<string,int,double>("Bug Spray",bugSprayQty1 ,bugSprayPrice1),
                                                                                            new Tuple<string,int,double>("Widgets",widgetsQty1 ,widgetsPrice1),
                                                                                            new Tuple<string,int,double>("Kryptonite",kryptoniteQty1 ,kryptonitePrice1),
                                                                                            new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",honeyQty1,honeyPrice1),
                                                                                            new Tuple<string,int,double>("Zombie Repellent",zombieRepellentQty1 ,zombieRepellentPrice1),
                                                                                            new Tuple<string,int,double>("Sun Screen",sunScreenQty1,sunScreenPrice1)};


            int firstItem = random.Next(0, 1);
            int secondItem = random.Next(2, 3);
            int thirdItem = random.Next(4, 5);
            int fourthItem = random.Next(6, 7);



            return (firstItem, secondItem, thirdItem, fourthItem, ThingsToBuy);
        }

        private (int, int, int, int, List<Tuple<string, int, double>>) InventoryGeneratorSell()
        {
            Random random = new Random();

            double marsBarsPrice = random.Next(100, 500);
            double moonPiePrice = random.Next(500, 1000);
            double bugSprayPrice = random.Next(25, 100);
            double widgetsPrice = random.Next(300, 1600);
            double kryptonitePrice = random.Next(5000, 18000);
            double honeyPrice = random.Next(1, 60);
            double zombieRepellentPrice = random.Next(1000, 22000);
            double sunScreenPrice = random.Next(15,365);

            int marBarsQty = random.Next(100, 500);
            int moonPieQty = random.Next(1, 1000);
            int bugSprayQty = random.Next(1, 1500);
            int widgetsQty = random.Next(500, 850);
            int kryptoniteQty = random.Next(6, 87);
            int honeyQty = random.Next(1000, 100000);
            int zombieRepellentQty = random.Next(1, 100);
            int sunScreenQty = random.Next(15, 8200);

            List<Tuple<string, int, double>> ThingsForSale = new List<Tuple<string, int, double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty ,marsBarsPrice),
                                                                                                      new Tuple<string,int,double>("Moon Pies",moonPieQty ,moonPiePrice),
                                                                                                      new Tuple<string,int,double>("Bug Spray",bugSprayQty ,bugSprayPrice),
                                                                                                      new Tuple<string,int,double>("Widgets",widgetsQty ,widgetsPrice),
                                                                                                      new Tuple<string,int,double>("Kryptonite",kryptoniteQty ,kryptonitePrice),
                                                                                                      new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",honeyQty,honeyPrice),
                                                                                                      new Tuple<string,int,double>("Zombie Repellent",zombieRepellentQty ,zombieRepellentPrice),
                                                                                                      new Tuple<string, int, double>("Sun Screen",sunScreenQty,sunScreenPrice)};
                                 
            int firstItem = random.Next(0, 1);
            int secondItem = random.Next(2, 3);
            int thirdItem = random.Next(4, 5);
            int fourthItem = random.Next(6, 7);

            return (firstItem, secondItem, thirdItem, fourthItem, ThingsForSale);
        }

        private void Inventory(int firstItem, int secondItem, int thirdItem, int fourthItem, List<Tuple<string, int, double>> ThingsForSale)
        {
            Console.WriteLine($"1) Item: {ThingsForSale[firstItem].Item1} || Quantity: {ThingsForSale[firstItem].Item2:n}  ||  Price: {ThingsForSale[firstItem].Item3:C}");
            Console.WriteLine($"2) Item: {ThingsForSale[secondItem].Item1} || Quantity: {ThingsForSale[secondItem].Item2:n}  ||  Price: {ThingsForSale[secondItem].Item3:C}");
            Console.WriteLine($"3) Item: {ThingsForSale[thirdItem].Item1} || Quantity: {ThingsForSale[thirdItem].Item2:n}  ||  Price: {ThingsForSale[thirdItem].Item3:C}");
            Console.WriteLine($"4) Item: {ThingsForSale[fourthItem].Item1} || Quantity: {ThingsForSale[fourthItem].Item2:n}  ||  Price: {ThingsForSale[fourthItem].Item3:C}");


        }

        private bool BuyMenu((int, int, int, int, List<Tuple<string, int, double>>) inventory)
        {
            Console.Clear();

            Console.WriteLine("Here are the things I have for sale.\n\n");

            Inventory(inventory.Item1, inventory.Item2, inventory.Item3, inventory.Item4, inventory.Item5);

            return true;
        }

        private bool SellMenu((int, int, int, int, List<Tuple<string, int, double>>) inventory)
        {
            Console.Clear();

            Console.WriteLine("Here are the things I am willing to buy.\n\n");

            Inventory(inventory.Item1, inventory.Item2, inventory.Item3, inventory.Item4, inventory.Item5);

            return true;
        }

        private void InTheMarket((int, int, int, int, List<Tuple<string, int, double>>)Buy, (int, int, int, int, List<Tuple<string, int, double>>)Sell)
        {
            bool inTheMarket = true;
 
            FirstMenu();
            SecondMenu();
            while (inTheMarket)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.Clear();
                SecondMenu();
                switch (userInput.Key)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        BuyMenu(Buy);
                        break;

                    case ConsoleKey.D1:
                        Console.Clear();
                        BuyMenu(Buy);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        SellMenu(Sell);
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        SellMenu(Sell);
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        inTheMarket = false;
                        break;
                }

            }


        }

        public void MarketPlaceMethod()
        {

            (int, int, int, int, List<Tuple<string, int, double>>) Buy = InventoryGeneratorBuy();
            (int, int, int, int, List<Tuple<string, int, double>>) Sell = InventoryGeneratorSell();

            InTheMarket(Buy, Sell);
        }



    }
}

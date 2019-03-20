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
        Random r;
        public MarketPlace(ref Random r)
        {
            this.r = r;
        }
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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");
            
        }

        /// <summary>
        /// Generates the items the user can purchase.
        /// </summary>
        /// <param name="ThingsForSale"></param>
        public  void BuyMenu(List<Tuple<string,int,double>> ThingsICanBuy)
        {
            
            Random random = new Random();
                       
            int firstItem1 = random.Next(0, 2);
            int secondItem1 = random.Next(2, 4);
            int thirdItem1 = random.Next(4, 6);
            int fourthItem1 = random.Next(6, 8);


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Here are the things I have for sale.");
            Console.WriteLine("==============================================\n\n");

            BuyInventory(ThingsICanBuy,firstItem1, secondItem1, thirdItem1, fourthItem1);


                                                                           
        }
        private List<Tuple<string, int, double>> ThingsToBuy()
        {

            double marsBarsPrice = r.Next(100, 500);
            int marBarsQty = r.Next(100, 500);

            double moonPiePrice = r.Next(500, 1000);
            int moonPieQty = r.Next(1, 1000);

            double bugSprayPrice = r.Next(25, 100);
            int bugSprayQty = r.Next(1, 1500);

            double widgetsPrice = r.Next(300, 1600);
            int widgetsQty = r.Next(500, 850);

            double kryptonitePrice = r.Next(5000, 18000);
            int kryptoniteQty = r.Next(6, 87);

            double honeyPrice = r.Next(1, 60);
            int honeyQty = r.Next(1000, 100000);

            double zombieRepellentPrice = r.Next(1000, 22000);
            int zombieRepellentQty = r.Next(1, 100);

            double sunScreenPrice = r.Next(5, 49);
            int sunScreenQty = r.Next(1500, 100000);

            List<Tuple<string, int, double>> ThingsICanBuy = new List<Tuple<string, int, double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty ,marsBarsPrice),
                                                                                            new Tuple<string,int,double>("Moon Pies",moonPieQty ,moonPiePrice),
                                                                                            new Tuple<string,int,double>("Bug Spray",bugSprayQty ,bugSprayPrice),
                                                                                            new Tuple<string,int,double>("Widgets",widgetsQty ,widgetsPrice),
                                                                                            new Tuple<string,int,double>("Kryptonite",kryptoniteQty ,kryptonitePrice),
                                                                                            new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",honeyQty,honeyPrice),
                                                                                            new Tuple<string,int,double>("Zombie Repellent",zombieRepellentQty ,zombieRepellentPrice),
                                                                                            new Tuple<string, int, double>("Sun Screen",sunScreenQty,sunScreenPrice)};

            return ThingsICanBuy;
        }


        /// <summary>
        /// Generates the menu the merchant in willing to buy.
        /// </summary>
        /// <param name="ThingsForSale"></param>
        public void SellMenu(List<Tuple<string, int, double>> ThingsIWantToSell)
        {
            Random random = new Random();

            int firstItem = random.Next(0, 2);
            int secondItem = random.Next(2, 4);
            int thirdItem = random.Next(4, 6);
            int fourthItem = random.Next(6, 8);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Here are the things I am willing to buy.");
            Console.WriteLine("==============================================\n\n");
            SellInventory(ThingsIWantToSell, firstItem, secondItem, thirdItem, fourthItem);
        }
        private List<Tuple<string, int, double>> ThingsToSell()
        {

            double marsBarsPrice = r.Next(100, 500);
            int marBarsQty = r.Next(100,500);

            double moonPiePrice = r.Next(500, 1000);
            int moonPieQty = r.Next(1,1000);

            double bugSprayPrice = r.Next(25,100);
            int bugSprayQty = r.Next(1,1500);

            double widgetsPrice = r.Next(300,1600);
            int widgetsQty = r.Next(500,850);

            double kryptonitePrice = r.Next(5000,18000);
            int kryptoniteQty = r.Next(6,87);

            double honeyPrice = r.Next(1,60);
            int honeyQty = r.Next(1000,100000);

            double zombieRepellentPrice = r.Next(1000,22000);
            int zombieRepellentQty = r.Next(1,100);

            double sunScreenPrice = r.Next(5,49);
            int sunScreenQty = r.Next(1500,100000);

            List<Tuple<string, int, double>> ThingsIWantToSell = new List<Tuple<string,int,double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty ,marsBarsPrice),
                                                                                            new Tuple<string,int,double>("Moon Pies",moonPieQty ,moonPiePrice),
                                                                                            new Tuple<string,int,double>("Bug Spray",bugSprayQty ,bugSprayPrice),
                                                                                            new Tuple<string,int,double>("Widgets",widgetsQty ,widgetsPrice),
                                                                                            new Tuple<string,int,double>("Kryptonite",kryptoniteQty ,kryptonitePrice),
                                                                                            new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",honeyQty,honeyPrice),
                                                                                            new Tuple<string,int,double>("Zombie Repellent",zombieRepellentQty ,zombieRepellentPrice),
                                                                                            new Tuple<string, int, double>("Sun Screen", sunScreenQty, sunScreenPrice)};
            return ThingsIWantToSell;
        }
         



        private void BuyInventory(List<Tuple<string,int,double>> ThingsForSale , int firstItem, int secondItem, int thirdItem, int fourthItem)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"1) Item: {ThingsForSale[firstItem].Item1} || Quantity: {ThingsForSale[firstItem].Item2}  ||  Price: {ThingsForSale[firstItem].Item3:C}\n");
            Console.WriteLine($"2) Item: {ThingsForSale[secondItem].Item1} || Quantity: {ThingsForSale[secondItem].Item2}  ||  Price: {ThingsForSale[secondItem].Item3:C}\n");
            Console.WriteLine($"3) Item: {ThingsForSale[thirdItem].Item1} || Quantity: {ThingsForSale[thirdItem].Item2}  ||  Price: {ThingsForSale[thirdItem].Item3:C}\n");
            Console.WriteLine($"4) Item: {ThingsForSale[fourthItem].Item1} || Quantity: {ThingsForSale[fourthItem].Item2}  ||  Price: {ThingsForSale[fourthItem].Item3:C}");


        }
        private void SellInventory(List<Tuple<string, int, double>> ThingsForSale, int firstItem, int secondItem, int thirdItem, int fourthItem)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"1) Item: {ThingsForSale[firstItem].Item1} || Quantity: {ThingsForSale[firstItem].Item2}  ||  Price: {ThingsForSale[firstItem].Item3:C}\n");
            Console.WriteLine($"2) Item: {ThingsForSale[secondItem].Item1} || Quantity: {ThingsForSale[secondItem].Item2}  ||  Price: {ThingsForSale[secondItem].Item3:C}\n");
            Console.WriteLine($"3) Item: {ThingsForSale[thirdItem].Item1} || Quantity: {ThingsForSale[thirdItem].Item2}  ||  Price: {ThingsForSale[thirdItem].Item3:C}\n");
            Console.WriteLine($"4) Item: {ThingsForSale[fourthItem].Item1} || Quantity: {ThingsForSale[fourthItem].Item2}  ||  Price: {ThingsForSale[fourthItem].Item3:C}");


        }


        public void InTheMarket()
        {
            /// place the buy sell generators outside of the while loop. create an instance of the list
            /// inside the loop. Theory is that the list will not change until the player quits. The list however can be updated to reflect purchases
            List<Tuple<string, int, double>> buy = ThingsToBuy();
            List<Tuple<string, int, double>> sell = ThingsToSell();
            ChoiceMenu();

            bool inTheMarket = true;
            while (inTheMarket)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.Clear();
                ChoiceMenu();

                /// TODO: Add methods to 
                switch (userInput.Key)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        BuyMenu(buy);
                        inTheMarket = true;
                        break;


                    case ConsoleKey.D1:
                        Console.Clear();
                        BuyMenu(buy);
                        inTheMarket = true;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        SellMenu(sell);
                        inTheMarket = true;
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        SellMenu(sell);
                        inTheMarket = true;
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Exit");
                        inTheMarket = false;
                        break;/// Buy Menu Method

                        /// Sell Menu Method





                }


            }
        }


    }
}

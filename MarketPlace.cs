//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SpaceCadets
//{
//    class MarketPlace
//    {
//        public void Greeting()
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine("\t\tWelcome to the Market"); /// TODO: add something with more imagination later
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.WriteLine("=====================================================");
//            Console.WriteLine("=====================================================\n\n");
//        }
//        public void ChoiceMenu()
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("\tYou can do one of four things:\n" +
//                              "\n\t1) Buy Something" +
//                              "\n\t2) Sell Something" +
//                              "\n\t3) Stand around and be ackward" +
//                              "\n\t4) Leave -- although technically you aren't doing that HERE, ");
//            Console.WriteLine("\t            it's more of a transitory process that begins here,");
//            Console.WriteLine("\t            but if you do choose that option know that we are excited");
//            Console.WriteLine("\t            excited to be the start of that new journey in your life.");
//            Thread.Sleep(5000);
//            Console.Clear();
//            Greeting();
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("\tYou can do one of three things:\n" +
//                  "\n\t1) Buy Something" +
//                  "\n\t2) Sell Something" +
//                  "\n\t3) Leave [Escape Key]");
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");
//            MarketChoices();
//        }

//        private void MarketChoices()
//        {
//            ConsoleKeyInfo userInput = Console.ReadKey();
//            /// TODO: Add methods to 
//            switch (userInput.Key)
//            {
//                case ConsoleKey.NumPad1:
//                    Console.Clear();
//                    BuyMenu();
//                    break;

//                case ConsoleKey.D1:
//                    Console.Clear();
//                    BuyMenu();
//                    break;

//                case ConsoleKey.D2:
//                    Console.Clear();
//                    Console.WriteLine("Sell Things");
//                    break;

//                case ConsoleKey.NumPad2:
//                    Console.Clear();
//                    Console.WriteLine("Sell Things");
//                    break;

//                case ConsoleKey.Escape:
//                    Console.Clear();
//                    Console.WriteLine("Exit");

//                    break;


//            }
//        }

//        public  void BuyMenu(List<Tuple<string,int,double>> ThingsForSale)
//        {
//            /// TODO: Create seperate Method for buy generator
//            /// TODO: Create the INT qty generator
//            Random random = new Random();
                       
//            int firstItem = random.Next(0, 6);
//            int secondItem = random.Next(0, 6);
//            int thirdItem = random.Next(0, 6);
//            int fourthItem = random.Next(0, 6);



//            Console.WriteLine("Here are the things I have for sale.\n\n");



//            Inventory(ThingsForSale,firstItem, secondItem, thirdItem, fourthItem);
                                                                           
//        }
//        private List<Tuple<string, int, double>> ThingsForSale()
//        {
//            Random random = new Random();

//            double marsBarsPrice = random.Next(100, 500);
//            int marBarsQty = random.Next(100,500);

//            double moonPiePrice = random.Next(500, 1000);
//            int moonPieQty = random.Next(1,1000);

//            double bugSprayPrice = random.Next(25,100);
//            int bugSprayQty = random.Next(1,1500);

//            double widgetsPrice = random.Next(300,1600);
//            int widgetsQty = random.Next(500,850);

//            double kryptonitePrice = random.Next(5000,18000);
//            int kryptoniteQty = random.Next(6,87);

//            double honeyPrice = random.Next(1,60);
//            int honeyQty = random.Next(1000,100000);

//            double zombieRepellentPrice = random.Next(1000,22000);
//            int zombieRepellentQty = random.Next(1,100);

//            double sunScreenPrice = random.Next(5,49);
//            int sunScreenQty = random.Next(1500,100000);

//            List<Tuple<string, int, double>> ThingsForSale = new List<Tuple<string,int,double>>() { new Tuple<string,int,double>("Mars Bars",marBarsQty ,marsBarsPrice),
//                                                                                            new Tuple<string,int,double>("Moon Pies",moonPieQty ,moonPiePrice),
//                                                                                            new Tuple<string,int,double>("Bug Spray",bugSprayQty ,bugSprayPrice),
//                                                                                            new Tuple<string,int,double>("Widgets",widgetsQty ,widgetsPrice),
//                                                                                            new Tuple<string,int,double>("Kryptonite",kryptoniteQty ,kryptonitePrice),
//                                                                                            new Tuple<string,int,double>("Honey [sourced by local Promixa Bees]",honeyQty,honeyPrice),
//                                                                                            new Tuple<string,int,double>("Zombie Repellent",zombieRepellentQty ,zombieRepellentPrice)};

//            return ThingsForSale;
//        }
         

//        private void Inventory(List<Tuple<string,int,double>> ThingsForSale , int firstItem, int secondItem, int thirdItem, int fourthItem)
//        {
//            Console.WriteLine($"1) Item: {ThingsForSale[firstItem].Item1} || Quantity: {ThingsForSale[firstItem].Item2:C}  ||  Price: {ThingsForSale[firstItem].Item3:n}");
//            Console.WriteLine($"2) Item: {ThingsForSale[secondItem].Item1} || Quantity: {ThingsForSale[secondItem].Item2:C}  ||  Price: {ThingsForSale[secondItem].Item3:n}");
//            Console.WriteLine($"3) Item: {ThingsForSale[thirdItem].Item1} || Quantity: {ThingsForSale[thirdItem].Item2:C}  ||  Price: {ThingsForSale[thirdItem].Item3:n}");
//            Console.WriteLine($"4) Item: {ThingsForSale[fourthItem].Item1} || Quantity: {ThingsForSale[fourthItem].Item2:C}  ||  Price: {ThingsForSale[fourthItem].Item3:n}");


//        }

//        public void SellMenu()
//        {

//        }
//        public void InTheMarket()
//        {
//            /// place the buy sell generators outside of the while loop. create an instance of the list
//            /// inside the loop. Theory is that the list will not change until the player quits. The list however can be updated to reflect purchases
//            List<Tuple<string, int, double>> buy = ThingsForSale();
//            bool inTheMarket = true;
//            while (inTheMarket)
//            {
//                ConsoleKeyInfo userInput = Console.ReadKey();
//                Console.Clear();
//                ChoiceMenu();

//                /// TODO: Add methods to 
//                switch (userInput.Key)
//                {
//                    case ConsoleKey.NumPad1:
//                        Console.Clear();
//                        BuyMenu(buy);
//                        inTheMarket = true;
//                        break;
                       

//                    case ConsoleKey.D1:
//                        Console.Clear();
//                        BuyMenu(buy);

//                        break;

//                    case ConsoleKey.D2:
//                        Console.Clear();
//                        Console.WriteLine("Sell Things");
//                        break;

//                    case ConsoleKey.NumPad2:
//                        Console.Clear();
//                        Console.WriteLine("Sell Things");
//                        break;

//                    case ConsoleKey.Escape:
//                        Console.Clear();
//                        Console.WriteLine("Exit");

//                        break;/// Buy Menu Method

//                        /// Sell Menu Method





//                }


//            }

//    }
//}

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



        private void BuyItemsMenu(List<Tuple<string, int, double>> buy)
        {
            int i = 0;
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 1;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 1;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 2;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 2;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[2].Item1} || Quantity: {buy[2].Item2} || Price: {buy[2].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 3;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[3].Item1} || Quantity: {buy[3].Item2} || Price: {buy[3].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 3;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 4;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 4;
                    BuyChoiceSelection(buy,i);
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }
        /// <summary>
        /// TODO: Update account and Inventory
        /// </summary>
        /// <param name="sell"></param>
      

        private void BuyChoiceSelection(List<Tuple<string, int, double>> sell, int i)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Enter Qty to purchase: \n");
                    int qtyToPurchase = Console.Read();
                    double price = qtyToPurchase * sell[i].Item3;
                    Console.WriteLine($"That will cost {price:C}");
                    Console.WriteLine("Do you wish to complete the purchase?\n");
                    Console.WriteLine("1) Yes");/// update bank account and inventory
                    Console.WriteLine("2) No"); /// leave
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.Write("Enter Qty to purchase: \n");
                    int qtyToPurchase_ = Console.Read();
                    double price_ = qtyToPurchase_ * sell[i].Item3;
                    Console.WriteLine($"That will cost {price_:C}");
                    Console.WriteLine("Do you wish to complete the purchase?\n");
                    Console.WriteLine("1) Yes");/// update bank account and inventory
                    Console.WriteLine("2) No"); /// leave
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }

        public List<ItemResources> MasterInventory()
        {
            Planet planet = new Planet();
            var planetList = planet.PlanetSystem();
            ItemResources MarsBars = new ItemResources(planetList[0], "Mars Bars", 500, 250);
            ItemResources SunScreen = new ItemResources(planetList[0], "Sun Screen", 1, 100); /// stretch goal. sell 42 to earth you get $500,000
            ItemResources MoonPies = new ItemResources(planetList[1], "Moon Pies", 1000, 750);
            ItemResources Honey = new ItemResources(planetList[2], "Honey[sourced by local Promixa Bees]", 1000, 500);
            ItemResources Widgets = new ItemResources(planetList[4], "Widgets",18000,25);
            ItemResources BugSprayPrice = new ItemResources(planetList[5], "Bug Spray", 1000, 90);
            ItemResources ZombieRepellent = new ItemResources(planetList[6],"Zombie Repellent",15000, 60);
            ItemResources Kryptonite = new ItemResources(planetList[3], "Kryptonite", 300000, 5);

            List<ItemResources> MarketItems = new List<ItemResources>() { MarsBars, SunScreen, MoonPies, Honey, Widgets,
                                                                          BugSprayPrice, ZombieRepellent, Kryptonite};
            return MarketItems;

        }

        public void InTheMarket()
        {
                       
            
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
                        List<Tuple<string, int, double>> purchase = BuyMenu(buy);
                        BuyItemsMenu(purchase);
                        inTheMarket = true;
                        break;


                    case ConsoleKey.D1:
                        Console.Clear();
                        BuyMenu(buy);
                        BuyItemsMenu(buy);
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

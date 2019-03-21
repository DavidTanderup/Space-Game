//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SomethingRandom
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
//        public void ChoiceMenuHeader()
//        {
//            Greeting();
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("\tYou can do one of four things:\n" +
//                              "\n\t1) Inventory" +
//                              "\n\t2) Stand around and be awkward" +
//                              "\n\t3) Leave -- although technically you aren't doing that HERE, ");
//            Console.WriteLine("\t            it's more of a transitory process that begins here,");
//            Console.WriteLine("\t            but if you do choose that option know that we are excited");
//            Console.WriteLine("\t            excited to be the start of that new journey in your life.");
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");

//        }





//        public void BuyChoiceSelection(Characters self, List<(MarketResources, int)> itemAndQuantity, int userSelection)
//        {
//            ConsoleKeyInfo userInput = Console.ReadKey();
//            switch (userInput.Key)
//            {
//                case ConsoleKey.D1:
//                    buyOptions(self, itemAndQuantity, userSelection); //fix this
//                    Console.Clear();
//                    Console.Write("Enter Qty to purchase: \n");
//                    int qtyToPurchase = Console.Read();
//                    double price = qtyToPurchase * itemAndQuantity[userSelection].Item1.Price; //add error if quantity exceeds stock
//                    Console.WriteLine($"That will cost {price:C}");
//                    Console.WriteLine("Do you wish to complete the purchase?\n");
//                    Console.WriteLine("1) Yes");/// update bank account and inventory
//                    Console.WriteLine("2) No"); /// leave
//                    break;

//                case ConsoleKey.D1:




//                case ConsoleKey.NumPad1:
//                    buyOptions(self, itemAndQuantity, userSelection);

//                    Console.Clear();
//                    Console.Write("Enter Qty to purchase: \n");
//                    int qtyToPurchaseNumPad = Console.Read();
//                    double priceNumPad = qtyToPurchaseNumPad * itemAndQuantity.Item1.Price; //add error if quantity exceeds stock
//                    Console.WriteLine($"That will cost {priceNumPad:C}");
//                    Console.WriteLine("Do you wish to complete the purchase?\n");
//                    Console.WriteLine("1) Yes");/// update bank account and inventory
//                    Console.WriteLine("2) No"); /// leave

//                    ConsoleKeyInfo option;
//                    option = Console.ReadKey();
//                    switch (option.Key)
//                    {
//                        case ConsoleKey.Y:
//                            if (price <= self.money)
//                                self.money -= price;
//                            self.inventory.Add(itemAndQuantity);
//                            //self.inventory += itemquantity
//                            break;



//                    }
//                    break;
//                case ConsoleKey.Escape:
//                    break;
//            }
//        }

//        private void buyOptions(Characters self, bool v1, int v2, int i)
//        {
//            throw new NotImplementedException();
//        }

//        /// <summary>
//        /// TODO: Update account and Inventory
//        /// </summary>
//        /// <param name="sell"></param>
//        private void BuyItemsMenu(Characters self, List<(MarketResources, int)> buy)
//        //private void BuyItemsMenu(List<Tuple<string, int, double>> buy)
//        {
//            int i = 0;
//            ConsoleKeyInfo userInput = Console.ReadKey();
//            switch (userInput.Key)
//            {
//                case ConsoleKey.D1:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[0].Item1.Name} || Quantity: {buy[0].Item2} || Price: {buy[0].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 1;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.NumPad1:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[0].Item1.Name} || Quantity: {buy[0].Item2} || Price: {buy[0].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 1;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.D2:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[1].Item1.Name} || Quantity: {buy[1].Item2} || Price: {buy[1].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 2;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.NumPad2:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[1].Item1.Name} || Quantity: {buy[1].Item2} || Price: {buy[1].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 2;
//                    BuyChoiceSelection(self, buy, i);
//                    break;
//                case ConsoleKey.D3:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[2].Item1.Name} || Quantity: {buy[2].Item2} || Price: {buy[2].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 3;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.NumPad3:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[2].Item1.Name} || Quantity: {buy[2].Item2} || Price: {buy[2].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 3;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.D4:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[3].Item1.Name} || Quantity: {buy[3].Item2} || Price: {buy[3].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 4;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.NumPad4:
//                    Console.Clear();
//                    Console.WriteLine($"Item: {buy[3].Item1.Name} || Quantity: {buy[3].Item2} || Price: {buy[3].Item1.Price}\n");
//                    Console.WriteLine("1) Purchase");
//                    Console.WriteLine("2) Leave");
//                    i = 4;
//                    BuyChoiceSelection(self, buy, i);
//                    break;

//                case ConsoleKey.Escape:
//                    break;
//            }
//        }

//        public List<MarketResources> Resources()
//        {
//            Planet planet = new Planet();
//            var planetList = planet.PlanetSystem();

//            MarketResources MarsBars = new MarketResources(planetList[0], "Mars Bars", 250);
//            MarketResources SunScreen = new MarketResources(planetList[0], "Sun Screen", 1); /// TODO: 42 sold on earth will give $500,000
//            MarketResources MoonPies = new MarketResources(planetList[1], "Moon Pies", 200);
//            MarketResources Honey = new MarketResources(planetList[2], "Honey [sourced by local Proxima Bees]", 500);
//            MarketResources Kryptonite = new MarketResources(planetList[3], "Kryptonite", 15000);
//            MarketResources Widgets = new MarketResources(planetList[4], "Widget", 800);
//            MarketResources BugSpray = new MarketResources(planetList[5], "Bug Spray by K", 486);
//            MarketResources ZombieRepellent = new MarketResources(planetList[6], "Zombie Repellent", 7200);

//            List<MarketResources> Inventory = new List<MarketResources>() { MarsBars, SunScreen, MoonPies, Honey, Kryptonite, Widgets, BugSpray, ZombieRepellent };
//            return Inventory;
//        }

//        private void Inventory(string buySell)
//        {
//            var marketDisplay = Resources();

//            int i = 0;
//            foreach (var item in marketDisplay)
//            {
//                if (buySell.ToLower() == "sell")
//                {
//                    Console.WriteLine($"Item: {marketDisplay[i].Name} || Quantity: {marketDisplay[i].} || Price {(marketDisplay[i].Price) * .75:C}");

//                }
//                else if (buySell.ToLower() != "sell")
//                {
//                    Console.WriteLine($"Item: {marketDisplay[i].Name} || Quantity: {marketDisplay[i].Quantity} || Price {marketDisplay[i].Price:C}");

//                }

//                i++;
//            }
//        }

//        public void InTheMarketPlace()
//        {
//            Console.Clear();
//            bool stillHere = true;

//            ChoiceMenuHeader();

//            while (stillHere)
//            {

//                ConsoleKeyInfo userInput = Console.ReadKey();
//                Console.Clear();
//                ChoiceMenuHeader();

//                switch (userInput.Key)
//                {
//                    case ConsoleKey.D1:
//                        Console.Clear();
//                        Inventory("");
//                        stillHere = true;
//                        break;

//                    case ConsoleKey.NumPad1:
//                        Console.Clear();
//                        Inventory("");
//                        stillHere = true;
//                        break;

//                    case ConsoleKey.D2:
//                        Console.Clear();
//                        Inventory("sell");
//                        stillHere = true;
//                        break;

//                    case ConsoleKey.NumPad2:
//                        Console.Clear();
//                        Inventory("sell");
//                        stillHere = true;
//                        break;

//                    case ConsoleKey.Escape:
//                        Console.Clear();
//                        Console.WriteLine("Exit");
//                        stillHere = false;
//                        break;



//                }

//            }
//        }



//    }

//}
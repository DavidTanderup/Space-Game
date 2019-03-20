﻿using System;
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

        /// <summary>
        /// TODO: Update account and Inventory
        /// </summary>
        /// <param name="sell"></param>
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
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 1;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 2;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 2;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[2].Item1} || Quantity: {buy[2].Item2} || Price: {buy[2].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 3;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[3].Item1} || Quantity: {buy[3].Item2} || Price: {buy[3].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 3;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 4;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 4;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }
        public List<MarketResources> Resources()
        {
            Planet planet = new Planet();
            var planetList = planet.PlanetSystem();
            MarketResources MarsBars = new MarketResources(planetList[0], "Mars Bars", 500, 250);
            MarketResources SunScreen = new MarketResources(planetList[0], "Sun Screen", 100, 1); /// TODO: 42 sold on earth will give $500,000
            MarketResources MoonPies = new MarketResources(planetList[1], "Moon Pies", 600, 200);
            MarketResources Honey = new MarketResources(planetList[2], "Honey [sourced by local Proxima Bees]", 1000, 500);
            MarketResources Kryptonite = new MarketResources(planetList[3], "Kryptonite", 500, 15000);
            MarketResources Widgets = new MarketResources(planetList[4], "Widget", 1000, 800);
            MarketResources BugSpray = new MarketResources(planetList[5], "Bug Spray by K", 1000, 486);
            MarketResources ZombieRepellent = new MarketResources(planetList[6], "Zombie Repellent", 750, 7200);

            List<MarketResources> Inventory = new List<MarketResources>() { MarsBars, SunScreen, MoonPies, Honey, Kryptonite, Widgets, BugSpray, ZombieRepellent };
            return Inventory;
        }

        private void Inventory(string buySell)
        {
            var marketDisplay = Resources();

            int i = 0;
            foreach (var item in marketDisplay)
            {
                if (buySell.ToLower() == "sell")
                {
                    Console.WriteLine($"Item: {marketDisplay[i].Name} || Quantity: {marketDisplay[i].Quantity} || Price {(marketDisplay[i].Price) * .75:C}");

                }
                else if (buySell.ToLower() != "sell")
                {
                    Console.WriteLine($"Item: {marketDisplay[i].Name} || Quantity: {marketDisplay[i].Quantity} || Price {marketDisplay[i].Price:C}");

                }

                i++;
            }
        }

        public void InTheMarketPlace()
        {

            bool stillHere = true;

            ChoiceMenu();
            
            while (stillHere)
            {

                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.Clear();
                ChoiceMenu();

                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Inventory("");
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Inventory("");
                        stillHere = true;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Inventory("sell");
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Inventory("sell");
                        stillHere = true;
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Exit");
                        stillHere = false;
                        break;



                }

            }
        }



    }

}
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
        public void ChoiceMenuHeader()
        {
            Greeting();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tYou can do one of four things:\n" +
                              "\n\t1) Inventory" +
                              "\n\t2) Stand around and be awkward" +
                              "\n\tEsc) Leave -- although technically you aren't doing that HERE, ");
            Console.WriteLine("\t            it's more of a transitory process that begins here,");
            Console.WriteLine("\t            but if you do choose that option know that we are excited");
            Console.WriteLine("\t            excited to be the start of that new journey in your life.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");

        }


        public void InTheMarketPlace(Characters self, List<(MarketResources, int)> planetInventory)
        {
            Console.Clear();
            bool stillHere = true;

            ChoiceMenuHeader();

            while (stillHere)
            {

                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.Clear();
                ChoiceMenuHeader();

                switch (userInput.Key)
                {
                    case ConsoleKey.D1:               
                        InventoryMenu(self, planetInventory);
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad1:
                        InventoryMenu(self, planetInventory);
                        stillHere = true;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(500);
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(500);
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

        public void InventoryMenu(Characters self, List<(MarketResources resource, int quantity)> PlanetInventory)
        {
            Console.Clear();
            Console.WriteLine("Please select an option to buy or sell if you have some." +
                 "\nWe're fair traders, we trade at face value.");

            for (int i = 0; i < PlanetInventory.Count; i++)
            {
                Console.WriteLine($"Item: {PlanetInventory[i].resource.Name} || Quantity: {PlanetInventory[i].quantity} || Price: {PlanetInventory[i].resource.Price}\n");
            }

            ConsoleKeyInfo userSelect;
            while (true)
            {
                userSelect = Console.ReadKey();
                switch (userSelect.Key)
                {
                    case ConsoleKey.D1:
                        InventorySelection(self, PlanetInventory[0].resource, PlanetInventory[0].quantity);
                        break;

                    case ConsoleKey.D2:
                        InventorySelection(self, PlanetInventory[1].resource, PlanetInventory[1].quantity);
                        break;

                    case ConsoleKey.D3:
                        InventorySelection(self, PlanetInventory[2].resource, PlanetInventory[2].quantity);
                        break;

                    case ConsoleKey.D4:
                        InventorySelection(self, PlanetInventory[3].resource, PlanetInventory[3].quantity);
                        break;

                    case ConsoleKey.D5:
                        InventorySelection(self, PlanetInventory[4].resource, PlanetInventory[4].quantity);
                        break;

                    case ConsoleKey.D6:
                        InventorySelection(self, PlanetInventory[5].resource, PlanetInventory[5].quantity);
                        break;

                    case ConsoleKey.D7:
                        InventorySelection(self, PlanetInventory[6].resource, PlanetInventory[6].quantity);
                        break;

                    case ConsoleKey.D8:
                        InventorySelection(self, PlanetInventory[7].resource, PlanetInventory[7].quantity);
                        break;

                    case ConsoleKey.Escape:
                        InTheMarketPlace(self, PlanetInventory);
                        break;





                }



            }




        }

        public void InventorySelection(Characters self, MarketResources item, int quantity)
        {
            int myInventory = 0;
            for(int i=0; i<self.inventory.Count; i++)
            {
                try
                {
                    if (itemInInventory(self, item))
                    {
                        myInventory = self.inventory[i].Item2;
                    }
                }
                catch { Console.WriteLine("ya got nothin"); }

            }



            Console.Clear();
            Console.WriteLine($"You've selected {item.Name}.\n" +
                $"  Price: {item.Price} \n" +
                $"Quantity we have: {quantity}\n" +
                $"  Quantity you have {myInventory}\n" +
                $"Press 1 to buy\n" +
                $"Press 2 to sell\n");

            ConsoleKeyInfo itemOption;
            bool control = true;
            while (control)
            {
                itemOption = Console.ReadKey();
                switch (itemOption.Key)
                {
                    case ConsoleKey.D1:
                        userBuy(self, item);
                        break;

                    case ConsoleKey.D2:
                       // userSell(self, item);
                        break;

                    case ConsoleKey.Escape:
                        control = false;
                        break;
                }
                continue;
            }


            
        






        }

        private static void userBuy(Characters self, MarketResources item)
        {
            Console.WriteLine("How much would you like to buy?");
            bool success = int.TryParse(Console.ReadLine(), out int quantity);
            if (success && (self.mySpaceShip.cargobay.weight + quantity < self.mySpaceShip.cargobay.capacity))
            {
                buyItem(self, item, quantity);
            }

            else
            {
                Console.WriteLine("Please select an appropriate option");
            }
            








        }

        public int buyItem(Characters self, MarketResources item, int quantity)
        {
            if (self.money > item.Price * quantity)
            {
                self.money-= item.Price * quantity;
                if(itemInInventory(self, item))
                {
                    int index = findItem(self, item);


                }
                else
                {
                    self.inventory.Add((item, quantity));
                }
            }

            else
            {
                Console.WriteLine("You don't have enough money to complete this purchase");
            }
        }

        public int findItem(Characters self, MarketResources item)
        {
            for (int i = 0; i < self.inventory.Count; i++)
            {
                if(self.inventory[i].Item1.Name == item.Name)
                {
                    return i;
                }

            }

            return 9;
        }

        public bool itemInInventory(Characters self, MarketResources item)
        {
            for(int i=0; i<self.inventory.Count; i++)
            {
                if(item.Name == self.inventory[i].Item1.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }

}
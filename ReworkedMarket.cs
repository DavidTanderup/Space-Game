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
                              "\n\t1) Buy" +
                              "\n\t2) Sell" +
                              "\n\tStand around and be awkward" +
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
            Menus menu = new Menus();
            ChoiceMenuHeader();

            while (stillHere)
            {

                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.Clear();
                ChoiceMenuHeader();

                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        buyMenu(self, planetInventory);
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad1:
                        buyMenu(self, planetInventory);
                        stillHere = true;
                        break;

                    case ConsoleKey.D2:
                        sellMenu(self, planetInventory);
                        stillHere = true;
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(500);
                        stillHere = true;
                        break;

                    case ConsoleKey.Escape:
                        menu.MainMenu(self);
                        stillHere = false;
                        break;
                }

            }
        }

        public void buyMenu(Characters self, List<(MarketResources resource, int quantity)> PlanetInventory)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Please select an option to buy or sell if you have some." +
                    "\nWe're fair traders, we trade at face value." +
                    $"\nYou've got {self.money}\n\n");

                for (int i = 0; i < PlanetInventory.Count; i++)
                {
                    Console.WriteLine($"Item {i + 1}: {PlanetInventory[i].resource.Name} || Quantity: {PlanetInventory[i].quantity} || Price: {PlanetInventory[i].resource.Price}\n");
                }

                ConsoleKeyInfo userSelect;
                userSelect = Console.ReadKey();
                switch (userSelect.Key)
                {
                    case ConsoleKey.D1:
                        buySelection(self, PlanetInventory, 0);
                        break;

                    case ConsoleKey.D2:
                        buySelection(self, PlanetInventory, 1);
                        break;

                    case ConsoleKey.D3:
                        buySelection(self, PlanetInventory, 2);
                        break;

                    case ConsoleKey.D4:
                        buySelection(self, PlanetInventory, 3);
                        break;

                    case ConsoleKey.D5:
                        buySelection(self, PlanetInventory, 4);
                        break;

                    case ConsoleKey.D6:
                        buySelection(self, PlanetInventory, 5);
                        break;

                    case ConsoleKey.D7:
                        buySelection(self, PlanetInventory, 6);
                        break;

                    case ConsoleKey.D8:
                        buySelection(self, PlanetInventory, 7);
                        break;

                    case ConsoleKey.Escape:
                        InTheMarketPlace(self, PlanetInventory);
                        break;





                }



            }



        }

        public void buySelection(Characters self, List<(MarketResources resource, int quantity)> PlanetInventory, int selection)
        {
            //how much would they like to buy?
            MarketResources resource = PlanetInventory[selection].resource;
            int quantity = PlanetInventory[selection].quantity;
            (MarketResources resource, int quantity) newPlanetListElement = PlanetInventory[selection];
            bool leave = false;

            //do they have space?
            //do they have money?
            //do they want to buy?
            Console.Clear();
            Console.WriteLine($"Item: {resource.Name}\n" +
                $"Cost: {resource.Price}\n" +
                $"Units for Sale: {quantity}\n" +
                $"\n" +
                $"How much would you like to buy?");
            bool success = int.TryParse(Console.ReadLine(), out int desiredQuantity);
            double price = desiredQuantity * resource.Price;

            if (success && (desiredQuantity <= quantity) && (self.money >= price))
            {
                while (!leave)
                {
                    Console.WriteLine("[Janet] Press 'Y' for yes and 'N' for no");
                    Console.Write($"\nAre you sure you want to buy {desiredQuantity} for {price}?: ");
                    //sure you want to buy/ops
                    ConsoleKeyInfo buyOption;
                    buyOption = Console.ReadKey();
                    switch (buyOption.Key)
                    {
                        case ConsoleKey.Y:
                            self.money -= price; //sub cost
                            self.inventory[selection].Item2 += desiredQuantity; //add quantity to self.inventory
                                                                                //remove quantity from planetinventory//Nasty workaround, shouldve made an array!
                            newPlanetListElement.quantity -= desiredQuantity;
                            PlanetInventory.RemoveAt(selection);
                            PlanetInventory.Insert(selection, newPlanetListElement);
                            leave = true;
                            break;

                        case ConsoleKey.N:
                            leave = true;
                            //spit back out at previous screen
                            break;

                        default:
                            continue;
                    }

                }
            }
            else
            {
                Console.WriteLine("Please Try Again!");
                Thread.Sleep(1000);
            }

            //Item, cos,t units available, //space available
        }




        public void sellMenu(Characters self, List<(MarketResources resource, int quantity)> PlanetInventory)
        {
            Formulas form = new Formulas();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Please select an option to sell if you have some." +
                    "\nWe're fair traders, we trade at face value." +
                    $"\nYou've got {self.money}\n\n");

                for (int i = 0; i < PlanetInventory.Count; i++)
                {
                    self.inventory[i].resource.Price = form.ItemValue(self, self.inventory[i].resource);
                    Console.WriteLine($"Item {i + 1}: {self.inventory[i].resource.Name} || Quantity: {self.inventory[i].quantity} || Price: {self.inventory[i].resource.Price}\n");
                }

                ConsoleKeyInfo userSelect;
                userSelect = Console.ReadKey();
                switch (userSelect.Key)
                {
                    case ConsoleKey.D1:
                        sellSelection(self, PlanetInventory, 0);
                        break;

                    case ConsoleKey.D2:
                        sellSelection(self, PlanetInventory, 1);
                        break;

                    case ConsoleKey.D3:
                        sellSelection(self, PlanetInventory, 2);
                        break;

                    case ConsoleKey.D4:
                        sellSelection(self, PlanetInventory, 3);
                        break;

                    case ConsoleKey.D5:
                        sellSelection(self, PlanetInventory, 4);
                        break;

                    case ConsoleKey.D6:
                        sellSelection(self, PlanetInventory, 5);
                        break;

                    case ConsoleKey.D7:
                        sellSelection(self, PlanetInventory, 6);
                        break;

                    case ConsoleKey.D8:
                        sellSelection(self, PlanetInventory, 7);
                        break;

                    case ConsoleKey.Escape:
                        InTheMarketPlace(self, PlanetInventory);
                        break;
                }

            }
        }

        public void sellSelection(Characters self, List<(MarketResources resource, int quantity)> PlanetInventory, int selection)
        {
            //how much would they like to sell?
        MarketResources resource = self.inventory[selection].resource;
        int quantity = self.inventory[selection].quantity;
        (MarketResources resource, int quantity) newPlanetListElement = PlanetInventory[selection];
            bool leave = false;
        //do they have space?
        //do they have money?
        //do they want to buy?
        Console.Clear();
            Console.WriteLine($"Item: {resource.Name}\n" +
                $"Cost: {resource.Price}\n" +
                $"Units in inventory: {quantity}\n" +
                $"\n" +
                $"How much would you like to sell?");
        bool success = int.TryParse(Console.ReadLine(), out int desiredQuantity);
        double price = desiredQuantity * resource.Price;

            if (success && ((self.inventory[selection].quantity - desiredQuantity) >= 0))
            {
                while (!leave)
                {
                    Console.WriteLine($"Are you sure you want to sell {desiredQuantity} for {price}?");
                    //sure you want to buy/ops
                    ConsoleKeyInfo buyOption;
                    buyOption = Console.ReadKey();
                    switch (buyOption.Key)
                    {
                        case ConsoleKey.Y:
                            self.money += price; //sub cost
                            self.inventory[selection].quantity -= desiredQuantity;
                                                                                //remove quantity from self.inventory
                                                                                //add quantity to self.inventory
                                                                                //Nasty workaround, shouldve made an array!
                            newPlanetListElement.quantity += desiredQuantity;
                            PlanetInventory.RemoveAt(selection);
                            PlanetInventory.Insert(selection, newPlanetListElement);
                            leave = true;
                            break;

                        case ConsoleKey.N:
                            leave = true;
                            //spit back out at previous screen
                            break;

                        default:
                            continue;
                    }

}
            }
            else
            {
                Console.WriteLine("Please Try Again!");
                Thread.Sleep(1000);
            }

            //Item, cos,t units available, //space available
        }


    }
}




 



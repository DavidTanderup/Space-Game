using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships;

namespace SpaceCadets
{
    class MoonMarket
    {
        SpaceShip shipOptions = new SpaceShip();
        Menus menu = new Menus();

        public void moonMarketMenu(Characters self)
        {
            self.mySpaceShip = new SpaceShip(self.mySpaceShip.engines, self.mySpaceShip.fuel, self.mySpaceShip.cargobay);
            Console.Clear();
            Console.WriteLine($"Welcome to the moon market! Nice {self.mySpaceShip.name}\nWe don't have many goods here\njust spaceship upgrades!");
            Console.WriteLine($"\nYou have {self.money} to spend!");
            Console.WriteLine("\n 1. Engines\n 2. Fuel Tanks\n 3. Cargo Bay\n 4. Fill up your tank");

            ConsoleKeyInfo option;
            while (true)
            {
                option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        engineSelect(self);
                        break;

                    case ConsoleKey.D2:
                        fuelTankSelect(self);
                        break;


                    case ConsoleKey.D3:
                        cargoSelect(self);
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                       // Console.WriteLine("Fill your Tank");
                        double amount = self.mySpaceShip.fuel.capacity - self.mySpaceShip.fuel.weight;
                        Console.WriteLine($"You filled {amount} gallons!");
                        self.mySpaceShip.fuel.weight = self.mySpaceShip.fuel.capacity;
                        System.Threading.Thread.Sleep(1000);
                        moonMarketMenu(self);
                        break;

                    case ConsoleKey.Escape:
                        menu.MainMenu(self);
                        break;
                        
                }
            }


        }

        public void engineSelect(Characters self)
        {
            Console.Clear();
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine($"1. {shipOptions.Engine1.name}\t{shipOptions.Engine1.cost}");
            Console.WriteLine($"2. {shipOptions.Engine2.name}\t{shipOptions.Engine2.cost}");
            Console.WriteLine($"3. {shipOptions.Engine3.name}\t{shipOptions.Engine3.cost}");
            ConsoleKeyInfo engineOption;
            while (true)
            {
                engineOption = Console.ReadKey();
                switch (engineOption.Key)
                {
                    case ConsoleKey.D1:
                        self.mySpaceShip.engines = self.mySpaceShip.Engine1;
                        break;

                    case ConsoleKey.D2:
                        self.mySpaceShip.engines = self.mySpaceShip.Engine2;
                        self.money -= self.mySpaceShip.Engine2.cost;
                        break;

                    case ConsoleKey.D3:
                        self.mySpaceShip.engines = self.mySpaceShip.Engine3;
                        self.money -= self.mySpaceShip.Engine3.cost;
                        break;

                }
                moonMarketMenu(self);
            }
        }

        public void fuelTankSelect(Characters self)
        {
            Console.Clear();
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine($"1. {shipOptions.Fuel1.name}, {shipOptions.Fuel1.cost}");
            Console.WriteLine($"2. {shipOptions.Fuel2.name}, {shipOptions.Fuel2.cost}");
            Console.WriteLine($"3. {shipOptions.Fuel3.name}, {shipOptions.Fuel3.cost}");

            ConsoleKeyInfo engineOption;
            while (true)
            {
                engineOption = Console.ReadKey();
                switch (engineOption.Key)
                {
                    case ConsoleKey.D1:
                        self.mySpaceShip.fuel = shipOptions.Fuel1;
                        break;

                    case ConsoleKey.D2:
                        self.mySpaceShip.fuel = shipOptions.Fuel2;
                        break;
                    case ConsoleKey.D3:
                        self.mySpaceShip.fuel = shipOptions.Fuel3;
                        break;
                }
                moonMarketMenu(self);
            }
        }

        public void cargoSelect(Characters self)
        {
            Console.Clear();
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine($"1. {shipOptions.Cargo1.name}, {shipOptions.Cargo1.cost}");
            Console.WriteLine($"2. {shipOptions.Cargo2.name}, {shipOptions.Cargo2.cost}");
            Console.WriteLine($"3. {shipOptions.Cargo3.name}, {shipOptions.Cargo3.cost}");
            ConsoleKeyInfo engineOption;
            while (true)
            {
                engineOption = Console.ReadKey();
                switch (engineOption.Key)
                {
                    case ConsoleKey.D1:
                        self.mySpaceShip.cargobay = shipOptions.Cargo1;
                        break;

                    case ConsoleKey.D2:
                        self.mySpaceShip.cargobay = shipOptions.Cargo2;
                        self.money -= shipOptions.Cargo2.cost;
                        break;

                    case ConsoleKey.D3:
                        self.mySpaceShip.cargobay = shipOptions.Cargo3;
                        self.money -= shipOptions.Cargo3.cost;
                        break;
                }
                moonMarketMenu(self);
            }
        }
    }
}

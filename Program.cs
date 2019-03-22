using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using Graphics;

namespace SpaceCadets
{



    class Program
    {


        static void Main(string[] args)
        {
            Planet planet = new Planet();
            var planetList = planet.PlanetSystem();
            SpaceShip spaceShip = new SpaceShip();
            SpaceShip mySpace = new SpaceShip(spaceShip.Engine1,spaceShip.Fuel1,spaceShip.Cargo1);
           // Characters PlayerOne = new Characters(5000, 20, planetList[1], "Bob",mySpace , true, );
            RunProgram runProgram = new RunProgram();
            runProgram.Run();

           

            Console.ReadLine();


            //Characters self;



            //bool TheBeatGoesOn = true;
            //while (TheBeatGoesOn)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.SetCursorPosition(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
            //    Console.WriteLine("Ready Player One");
            //    Thread.Sleep(1200);
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.SetCursorPosition(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
            //    Console.WriteLine("Ready Player One");
            //    Thread.Sleep(1200);
            //    Console.Clear();
            //}



            ////    SaveAndLoadGame saveAndLoadGame = new SaveAndLoadGame();

            ////    List<Tuple<string, bool>> tuples = new List<Tuple<string, bool>>() { };
            ////    string fileLocation = saveAndLoadGame.FileLocation();
            ////    saveAndLoadGame.CreateNewSaveFile(fileLocation);
            ////    //marketPlace.Greeting();
            ////    //marketPlace.ChoiceMenu();


            Planet planette = new Planet();

            //Planet planet = new Planet();

            var ListofPlanets = planet.PlanetSystem();
            var Earth = ListofPlanets[0];
            //    var ProximaB = ListofPlanets[2];
            //string name = "bob";

            SpaceShip SpaceShipOptions = new SpaceShip();

            Engines myEngine = SpaceShipOptions.Engine1;
            Fuel myFuel = SpaceShipOptions.Fuel1;
            Cargo myCargo = SpaceShipOptions.Cargo1;

            SpaceShip mySpaceShip = new SpaceShip(myEngine, myFuel, myCargo);

            //    Formulas form = new Formulas();
            //Characters self = new Characters(5000, 12, Earth, name, mySpaceShip, true);
            //    ////SpaceShip mySpaceShip = new SpaceShip(myEngine, myFuel, myCargo);
            //MarketResources thing = new MarketResources();
            //var list = thing.MarketGenerate(self);

            //foreach ((MarketResources, int) element in list)
            //{
            //    Console.WriteLine($"{element.Item1.Name} has {element.Item2} units available worth {element.Item1.Price} each");
            //}

            //    //    ////string SpaceShipRep = mySpaceShip.Engine3.rep + mySpaceShip.Fuel3.rep + mySpaceShip.Cargo3.rep + mySpaceShip.nose;

            //    //    ////(double, double) Point1 = (2, 3);
            //    //    ////(double, double) Point2 = (0, 6);

            //    //    ////Console.WriteLine(form.Dist2Points(Point1, Point2));

            //    //    //// double WS = form.WarpSpeed(mySpaceShip.Engine1.speed);
            //    //    ////double Dist = form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate);
            //    //    ////Console.WriteLine($"Distance is {Dist} Light years");
            //    //    ////Console.WriteLine($"Travel time is {form.TravelTime(WS, Dist)*365} days");


            //    //    ////for (int i = 0; i < 10; i++)
            //    //    ////{
            //    //    ////    Console.WriteLine($"Speed {i} is {form.WarpSpeed(i)} x the Speed of Light");
            //    //    ////};
            //    //    //System.Threading.Thread.Sleep(2000);
            //    //    //Movement movemain = new Movement();
            //    //    //movemain.MovementMain(mySpaceShip, 1, 1); /// TODO: Update the method.

            //    //    //// Console.WriteLine($"The distance from {Earth.PlanetName} to {ProximaB.PlanetName} is {form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate)} Light Years");
            //    //    //// Console.WriteLine($"The speed of {mySpaceShip.name} is {form.WarpSpeed(mySpaceShip.speed)}");
            //    //    //// Console.WriteLine($"It will take {form.TravelTime(form.WarpSpeed(mySpaceShip.speed), form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate))} years");
            //    //    //int wWidth = Console.WindowWidth;
            //    //    //int wHeight = Console.WindowHeight;
            //    //    //Console.WriteLine("Something", wWidth, wHeight);
            //    MoonMarket menu = new MoonMarket();
            //    //Menus menu = new Menus();
            //    //menu.MainMenu(self);
            //    menu.moonMarketMenu(self);

            ////    menu.TravelPlanetPrompt(self, ProximaB);





            ////    //    Console.Clear();
            //////    Console.WriteLine("BOOM!");
            //////    System.Threading.Thread.Sleep(5000);
        }

    }
}

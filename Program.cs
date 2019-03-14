using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceCadets;
//using Graphics;
using Ships;

namespace ConsoleApp4
{



    class Program
    {



        static void Main(string[] args)
        {

            Planet planet = new Planet();
            var ListofPlanets = planet.PlanetSystem();
            var Earth = ListofPlanets[0];
            var ProximaB = ListofPlanets[2];

            SpaceShip SpaceShipOptions = new SpaceShip();

            Engines myEngine = SpaceShipOptions.Engine3;
            Fuel myFuel = SpaceShipOptions.Fuel3;
            Cargo myCargo = SpaceShipOptions.Cargo3;

            SpaceShip mySpaceShip = new SpaceShip(myEngine, myFuel, myCargo);

            Formulas form = new Formulas();
            //SpaceShip mySpaceShip = new SpaceShip(myEngine, myFuel, myCargo);
            //string SpaceShipRep = mySpaceShip.Engine3.rep + mySpaceShip.Fuel3.rep + mySpaceShip.Cargo3.rep + mySpaceShip.nose;

            //(double, double) Point1 = (2, 3);
            //(double, double) Point2 = (0, 6);

            //Console.WriteLine(form.Dist2Points(Point1, Point2));

            // double WS = form.WarpSpeed(mySpaceShip.Engine1.speed);
            //double Dist = form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate);
            //Console.WriteLine($"Distance is {Dist} Light years");
            //Console.WriteLine($"Travel time is {form.TravelTime(WS, Dist)*365} days");


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Speed {i} is {form.WarpSpeed(i)} x the Speed of Light");
            //};
            System.Threading.Thread.Sleep(2000);
            Movement movemain = new Movement();
            movemain.MovementMain(mySpaceShip.rep);

            // Console.WriteLine($"The distance from {Earth.PlanetName} to {ProximaB.PlanetName} is {form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate)} Light Years");
            // Console.WriteLine($"The speed of {mySpaceShip.name} is {form.WarpSpeed(mySpaceShip.speed)}");
            // Console.WriteLine($"It will take {form.TravelTime(form.WarpSpeed(mySpaceShip.speed), form.Dist2Points(Earth.PlanetCoordinate, ProximaB.PlanetCoordinate))} years");
            int wWidth = Console.WindowWidth;
            int wHeight = Console.WindowHeight;
            Console.WriteLine("Something", wWidth, wHeight);

            Console.Clear();
            Console.WriteLine("BOOM!");
            System.Threading.Thread.Sleep(5000);
        }

    }
}

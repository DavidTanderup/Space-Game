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
            RunProgram runProgram = new RunProgram();
            runProgram.Run();

           

            Console.ReadLine();                                              


            Planet planette = new Planet();


            var ListofPlanets = planet.PlanetSystem();
            var Earth = ListofPlanets[0];
            

            SpaceShip SpaceShipOptions = new SpaceShip();

            Engines myEngine = SpaceShipOptions.Engine1;
            Fuel myFuel = SpaceShipOptions.Fuel1;
            Cargo myCargo = SpaceShipOptions.Cargo1;

            SpaceShip mySpaceShip = new SpaceShip(myEngine, myFuel, myCargo);

    
        }

    }
}

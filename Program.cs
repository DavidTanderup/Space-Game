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




    
        }

    }
}

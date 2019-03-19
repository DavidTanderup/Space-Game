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
            MarketPlace marketPlace = new MarketPlace();
            SaveAndLoadGame saveAndLoadGame = new SaveAndLoadGame();

            List<Tuple<string, bool>> tuples = new List<Tuple<string, bool>>() { };
            string fileLocation = saveAndLoadGame.FileLocation();
            saveAndLoadGame.CreateNewSaveFile(fileLocation);
            //marketPlace.Greeting();
            //marketPlace.ChoiceMenu();
     



            Console.ReadLine();


        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    class SaveAndLoadGame
    {
        public string FileLocation()
        {
            string fileLocation = @"C:\Users\Program Files\Data2.dat";
            return fileLocation;
        }

        public void SaveItem(List<Tuple<string, bool>> MyList)
        {
            string fileLocation = FileLocation();


            FileStream stream = new FileStream(fileLocation, FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, MyList);

            stream.Close();
        }



    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    /// <summary>
    /// Find a way to create a save file. 
    /// </summary>
    class SaveAndLoadGame
    {
        public string FileLocation()
        {
            string fileLocation = @"%Userprofile\documents\Data2.dat";
            return fileLocation;
        }

        public void SaveItem(List<Tuple<string, bool>> MyList) /// TODO: Replace the input tuple types with current.
        {
            string fileLocation = FileLocation();


            FileStream stream = new FileStream(fileLocation, FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, MyList);

            stream.Close();
        }

        public void CreateNewSaveFile(string fileLocation)
        {

            

            List<Tuple<string, bool>> MyList = new List<Tuple<string, bool>>();


            try
            {

                FileStream inStr = new FileStream(fileLocation, FileMode.Open);

                BinaryFormatter bf = new BinaryFormatter();

                MyList = bf.Deserialize(inStr) as List<Tuple<string, bool>>;

                inStr.Close();

            }
            catch (FileNotFoundException)
            {
                FileStream stream = new FileStream(fileLocation, FileMode.CreateNew);

                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, MyList);

                stream.Close();

            }
        }



    }
}

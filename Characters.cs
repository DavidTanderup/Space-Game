using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships;

namespace SpaceCadets
{
    class Characters
    {
        public string Name;
        public int money;
        public double Age;
        string location;
        SpaceShip mySpaceShip = new SpaceShip();
        
        //skills
        //distance traveled


        public Characters(int money, double Age, string location)
        {           
            this.money = money;
            this.Age = Age;
            this.location = location;
           `
        }

    }
}

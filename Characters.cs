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
        public string name ;
        public int money;
        public double Age;
        public Planet location;
        public SpaceShip mySpaceShip = new SpaceShip();
        public bool Alive;
        
        //skills
        //distance traveled


        public Characters(int money, double Age, Planet location, string name, SpaceShip mySpaceShip, bool Alive)
        {           
            this.money = money;
            this.Age = Age;
            this.location = location;
            this.name = name;
            this.mySpaceShip = mySpaceShip;
            this.Alive = Alive;




        }

    }
}

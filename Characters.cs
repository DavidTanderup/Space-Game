using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class Characters
    {
        public string name;
        public double money;
        public double Age;
        public Planet location;
        public SpaceShip mySpaceShip = new SpaceShip();
        public bool Alive;
        //public List<(item item, double quantity)> inventory;
        public (MarketResources resource, int quantity)[] inventory = new (MarketResources resource, int quantity)[8];









    
    //modify cargo capacity


    //skills
    //distance traveled


    public Characters(int money, double Age, Planet location, string name, SpaceShip mySpaceShip, bool Alive, (MarketResources, int)[] inventory)
        {           
            this.money = money;
            this.Age = Age;
            this.location = location;
            this.name = name;
            this.mySpaceShip = mySpaceShip;
            this.Alive = Alive;
            this.inventory = inventory;
            
            



        }

    }
}

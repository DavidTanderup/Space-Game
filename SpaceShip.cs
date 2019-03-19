using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class SpaceShip
    {
        public string name;
        public string rep;
        public double speed;
        public int fuel;
        public int fuelCapacity;
        public int weight;
        public int cargoCapacity;

        public SpaceShip()
        {
            Engines engine = Engine1;
            Fuel fuel = Fuel1;
            Cargo cargo = Cargo1;
        }

        public SpaceShip(Engines engine, Fuel fuel, Cargo cargo)
        {
            this.name = engine.name + fuel.name + cargo.name;
            this.rep = engine.rep + fuel.rep + cargo.rep + nose;
            this.weight = engine.weight + fuel.weight + cargo.weight;
            this.speed = engine.speed;
            this.fuel = fuel.weight;
            this.fuelCapacity = fuel.capacity;
            this.cargoCapacity = cargo.capacity;
        }
        

    
        //Engines
        public Engines Engine1 = new Engines("WX100", ">=", 1, 100);
        public Engines Engine2 = new Engines("WX200", ">>==", 2, 300);
        public Engines Engine3 = new Engines("WX300", ">>>===", 2.5, 500);

        //Fuel
        public Fuel Fuel1 = new Fuel("-MiniGulp", "0",500 ,500, 500);
        public Fuel Fuel2 = new Fuel("-MidGulp", "00",1000 ,1000, 1000);
        public Fuel Fuel3 = new Fuel("-BigGulp", "000", 2000 ,2000, 2000);
        //Cargo
        public Cargo Cargo1 = new Cargo("-spacebay", "||", 2000, 0);
        public Cargo Cargo2 = new Cargo("-spaceBAY", "|||", 3000, 0);
        public Cargo Cargo3 = new Cargo("-spaceBAE", "||||", 5000, 0);

        public string nose = "=>";
        //nav
            //fuel efficiency "jump"
            //minigames decrease time
        //radio
            //mastermind leads to intercept message, better intel
    }

    public class Engines
    { 
        public string name = "";
        public string rep = ">";
        public double speed = 0;
        public int weight = 0;

        public Engines(string name, string rep, double speed, int weight)
        {
        this.name = name;
        this.rep = rep;
        this.speed = speed;
        this.weight = weight;

        }
    }

    class Fuel
    {
        public string name = "";
        public string rep = "";
        public int capacity = 0;
       // public int fuel = 0;
        public int weight = 0;
       

        public Fuel(string name, string rep, int fuel, int capacity, int weight)
        {
            this.name = name;
            this.rep = rep;
            //this.fuel = fuel;
            this.capacity = capacity;
            this.weight = weight; //This will be how much fuel is on board!!!
        }
    }

    class Cargo
    {
        public string name = "";
        public string rep = "";
        public int capacity = 0;
        public int weight = 0;

        public Cargo(string name, string rep, int capacity, int weight)
        {
            this.name = name;
            this.rep = rep;
            this.capacity = capacity;
            this.weight = weight;
        }




    }


}

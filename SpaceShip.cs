using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class SpaceShip
    {
        public string name;
        public string rep;
        //public double speed;
        //public double fuel;
        //public double fuelCapacity;
        //public double weight;
        //public double cargoCapacity;
        public Engines engines;
        public Fuel fuel;
        public Cargo cargobay;
        public SpaceShip()
        {
            Engines engines = Engine1;
            Fuel fuel = Fuel1;
            Cargo cargobay = Cargo1;
        }

        public SpaceShip(Engines engine, Fuel fuel, Cargo cargo)
        {
            this.name = engine.name + fuel.name + cargo.name;
            this.rep = engine.rep + fuel.rep + cargo.rep + nose;
            //this.weight = engine.weight + fuel.weight + cargo.weight;
            //this.speed = engine.speed;
            //this.fuel = fuel.weight;
            //this.fuelCapacity = fuel.capacity;
            //this.cargoCapacity = cargo.capacity;
            this.fuel = fuel;
            this.engines = engine;
            this.cargobay = cargo;
        }

        //public UpdateShip(SpaceShip ship)
        //{
        //    this.name = ship.engines.name + ship.fuel.name + ship.cargobay.name;
        //    this.rep = ship.engines.rep + ship.fuel.rep + ship.cargobay.rep + nose;
        //    this.fuel = ship.fuel;
        //    this.engines = ship.engines;
        //    this.cargobay = ship.cargobay;
        //}

    
        //Engines
        public Engines Engine1 = new Engines("WX100", ">=", 1, 100, 0);
        public Engines Engine2 = new Engines("WX200", ">>==", 2, 300, 2000);
        public Engines Engine3 = new Engines("WX300", ">>>===", 2.5, 500, 5000);

        //Fuel
        public Fuel Fuel1 = new Fuel("-MiniGulp", "0",500 ,2000, 500, 0);
        public Fuel Fuel2 = new Fuel("-MidGulp", "00",1000 ,3500, 1000, 2000);
        public Fuel Fuel3 = new Fuel("-BigGulp", "000", 2000 ,5000, 2000, 5000);
        //Cargo
        public Cargo Cargo1 = new Cargo("-spacebay", "||", 1000, 0, 0);
        public Cargo Cargo2 = new Cargo("-spaceBAY", "|||", 2000, 0, 2000);
        public Cargo Cargo3 = new Cargo("-spaceBAE", "||||", 3000, 0, 5000);

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
        public double weight = 0;
        public double cost = 0;

        public Engines(string name, string rep, double speed, double weight, double cost)
        {
        this.name = name;
        this.rep = rep;
        this.speed = speed;
        this.weight = weight;
        this.cost = cost;

        }
    }

    public class Fuel
    {
        public string name = "";
        public string rep = "";
        public double capacity = 0;
       // public int fuel = 0;
        public double weight = 0;
        public double cost = 0;


        public Fuel(string name, string rep, double fuel, double capacity, double weight, double cost)
        {
            this.name = name;
            this.rep = rep;
            //this.fuel = fuel;
            this.capacity = capacity;
            this.weight = weight; //This will be how much fuel is on board!!!
            this.cost = cost;
        }
    }

    public class Cargo
    {
        public string name = "";
        public string rep = "";
        public double capacity = 0;
        public double weight = 0;
        public double cost = 0;

        public Cargo(string name, string rep, double capacity, double weight, double cost)
        {
            this.name = name;
            this.rep = rep;
            this.capacity = capacity;
            this.weight = weight;
            this.cost = cost;
        }




    }


}

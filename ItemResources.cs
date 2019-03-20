using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class ItemResources
    {

        public string Name { get; set; }
        public int Qty { get; set; }
        public Planet HomePlanet { get; set; }
        public double Price { get; set; }
        //public List<Planet> galaxy { get; set; }

        public ItemResources(Planet planet, string ItemName, int ItemQty, double ItemPrice)
        {
            HomePlanet = planet;
            Name = ItemName;
            Qty = ItemQty;
            Price = ItemPrice;


            Planet somePlanet = new Planet();
            var galaxy = somePlanet.PlanetSystem();

        }


    }







}

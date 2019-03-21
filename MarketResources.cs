using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class MarketResources
    {
        public Planet Home { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public MarketResources()
        {
            Planet something = new Planet();
            Home = something;
            Name = "I am a name";
            Price = 0;
        }

        public MarketResources (Planet planet, string ItemName, /*int ItemQuantity,*/ double ItemPrice)
        {
            Home = planet;
            Name = ItemName;
            //Quantity = ItemQuantity;
            Price = ItemPrice;
        }



        public List<MarketResources> Resources()
        {
            Planet planet = new Planet();
            var planetList = planet.PlanetSystem();

            MarketResources MarsBars = new MarketResources(planetList[0], "Mars Bars", 250);
            MarketResources SunScreen = new MarketResources(planetList[0], "Sun Screen", 1); /// TODO: 42 sold on earth will give $500,000
            MarketResources MoonPies = new MarketResources(planetList[1], "Moon Pies", 200);
            MarketResources Honey = new MarketResources(planetList[2], "Honey [sourced by local Proxima Bees]", 500);
            MarketResources Kryptonite = new MarketResources(planetList[3], "Kryptonite", 15000);
            MarketResources Widgets = new MarketResources(planetList[4], "Widget", 800);
            MarketResources BugSpray = new MarketResources(planetList[5], "Bug Spray by K", 486);
            MarketResources ZombieRepellent = new MarketResources(planetList[6], "Zombie Repellent", 7200);

            List<MarketResources> Inventory = new List<MarketResources>() { MarsBars, SunScreen, MoonPies, Honey, Kryptonite, Widgets, BugSpray, ZombieRepellent };
            return Inventory;
        }

        public List<(MarketResources, int)> MarketGenerate(Characters self) //adjusts for distance inflation!
        {
            //Planet none = new Planet();
            MarketResources market = new MarketResources();
            List<MarketResources> allItems = market.Resources();

            Formulas form = new Formulas();


            //List<MarketResources> allItems = Resources();
            Random numbers = new Random();
            var inventory = new List<(MarketResources, int)> { };
            MarketResources itemsSelect;
            int quantity;
            for (int i = 0; i < allItems.Count; i++)
            {

                itemsSelect = allItems[i];

                quantity = numbers.Next(200, 2000);
                itemsSelect.Price = form.ItemValue(self, itemsSelect);
                inventory.Add((itemsSelect, quantity));

            }


            return inventory;
        }


    }
}

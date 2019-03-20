using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    class MarketResources
    {
        public Planet Home { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public MarketResources (Planet planet, string ItemName, int ItemQuantity, double ItemPrice)
        {
            Home = planet;
            Name = ItemName;
            Quantity = ItemQuantity;
            Price = ItemPrice;
        }

    }
}

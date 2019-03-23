using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    class Formulas
    {

        public double Dist2Points((double, double) Point1, (double, double) Point2)
        {
            return Math.Sqrt(Math.Pow((Point1.Item1 - Point2.Item1), 2) + Math.Pow((Point1.Item2 - Point2.Item2), 2));
        }


        public double WarpSpeed(double WarpFactor)
        {
            double term1 = Math.Pow(WarpFactor, (10.0 / 3.0));
            double term2 = Math.Pow((10 - WarpFactor), (-11.0 / 3.0));
            return term1 + term2;
            //basic
        }

        public double TravelTime(double WarpFactor, double DistanceLY)
        {
            return DistanceLY / WarpSpeed(WarpFactor); //This is time in years
        }


        public double ItemValue(SpaceCadets.Characters self, SpaceCadets.MarketResources item) //value-upper based on distance
        {
            
            double Distance = Dist2Points(self.location.PlanetCoordinate, item.Home.PlanetCoordinate);
            //return item.Price * (1 + .03 * Distance);
            double value = Math.Round(item.Price * (Math.Pow(1 + .02, Distance)));
            //double value = item.Price;
            return value; 
           
        }

    }
}

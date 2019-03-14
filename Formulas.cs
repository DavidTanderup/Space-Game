using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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

        public double TravelTime(double WarpSpeed, double DistanceLY)
        {
            return DistanceLY / WarpSpeed; //This is time in years
        }

    }
}

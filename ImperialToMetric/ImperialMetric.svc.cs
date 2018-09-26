using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImperialToMetric
{
    
    public class ImperialMetric : IImperialMetric
    {
        public double InchToMetre(string value)
        {
            double d = Convert.ToDouble(value);
            return (double)(d / (double)(0.03937 * 1000));
        }

        public double MetreToInch(string value)
        {
            double d = Convert.ToDouble(value);
            return (double)(d * (double)(0.03937 * 1000));
        }

        public double FootToMetre(string value)
        {
            double d = Convert.ToDouble(value);
            return d * 0.3048;
        }

        public double MetreToFoot(string value)
        {
            double d = Convert.ToDouble(value);
            return (double)(d / 0.3048);
        }

        public double YardToMetre(string value)
        {
            double d = Convert.ToDouble(value);
            return d * 0.9144;
        }

        public double MetreToYard(string value)
        {
            double d = Convert.ToDouble(value);
            return (double)(d / 0.9144);
        }

        public double MilesToMetre(string value)
        {
            double d = Convert.ToDouble(value);
            return d * (1.6093 * 1000);
        }

        public double MetreToMiles(string value)
        {
            double d = Convert.ToDouble(value);
            return (double)(d / (1.6093 * 1000));
        }
    }
}

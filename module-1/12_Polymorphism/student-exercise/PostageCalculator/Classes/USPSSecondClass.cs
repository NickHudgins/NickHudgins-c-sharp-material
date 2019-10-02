using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class USPSSecondClass : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)

        {
            if (distance == 0 && weight == 0)
            {
                return 0;
            }
            if (weight <= 2)
            {
                return 0.0035 * distance;
            }
            if (weight <= 8)
            {
                return 0.0040 * distance;
            }
            if (weight <= 15)
            {
                return 0.0047 * distance;
            }
            if (weight <= 48)
            {
                return 0.0195 * distance;
            }
            if (weight <= 128)
            {
                return 0.0450 * distance;
            }
            if (weight >= 144)
            {
                return 0.0500 * distance;
            }
            return 0;
        }
    }
}

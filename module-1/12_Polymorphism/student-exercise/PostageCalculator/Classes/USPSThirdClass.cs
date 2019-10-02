using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class USPSThirdClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)

        {
            if (distance == 0 && weight == 0)
            {
                return 0;
            }
            if (weight <= 2)
            {
                return 0.020 * distance;
            }
            if (weight <= 8)
            {
                return 0.022 * distance;
            }
            if (weight <= 15)
            {
                return 0.024 * distance;
            }
            if (weight <= 48)
            {
                return 0.150 * distance;
            }
            if (weight <= 128)
            {
                return 0.160 * distance;
            }
            if (weight >= 144)
            {
                return 0.170 * distance;
            }
            return 0;
        }
    }
}

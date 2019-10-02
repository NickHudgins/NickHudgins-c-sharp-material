using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class USPSFirstClass : IDeliveryDriver
    {
        
        public double CalculateRate(int distance, double weight)
         
        {
            if (distance == 0 && weight == 0)
            {
                return 0;
            }
            if (weight <= 2)
            {
                return 0.035 * distance;
            }
            if (weight <= 8)
            {
                return 0.040 * distance;
            }
            if (weight <= 15)
            {
                return 0.047 * distance;
            }
            if (weight <= 48)
            {
                return 0.195 * distance;
            }
            if (weight <= 128)
            {
                return 0.450 * distance;
            }
            if (weight >= 144)
            {
                return 0.500 * distance;
            }
            return 0;
        }





    }
}

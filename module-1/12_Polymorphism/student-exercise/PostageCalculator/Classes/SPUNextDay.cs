using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUNextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            return (weight * 0.0075) * distance;
        }
    }
}

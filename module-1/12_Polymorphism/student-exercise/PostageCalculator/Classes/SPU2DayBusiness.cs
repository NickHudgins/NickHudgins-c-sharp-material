using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU2DayBusiness : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            return (weight * 0.0050) * distance;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU4DayGround : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
                return (weight * 0.0050) * distance;
        }
    }
}

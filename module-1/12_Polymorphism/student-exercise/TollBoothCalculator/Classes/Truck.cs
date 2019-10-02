using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Truck :IVehicle
    {
        public int NumberOfAxles { get;  }

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

        public double toll = 0;
        public double CalculateToll(int distance)
        {
            if (NumberOfAxles == 4)
            {
                toll = 0.040 * distance;
            }
            if (NumberOfAxles == 6)
            {
                toll = 0.045 * distance;
            }
            if (NumberOfAxles >= 8)
            {
                toll = 0.048 * distance;
            }
            return toll;
        }
    }
}

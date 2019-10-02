using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }

        public double toll = 0;
        public double CalculateToll(int distance)
        {
            toll = distance * 0.020;
            if (HasTrailer)
            {
                toll++;
            }
            return toll;
        }










    }

    

}

using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Tank : IVehicle
    {
        public bool IsMilitaryVehicle { get; }

        public Tank(bool isMilitaryVehicle)
        {
            IsMilitaryVehicle = isMilitaryVehicle;
        }

        public double toll = 0;
        public double CalculateToll(int distance)
        {
            if (IsMilitaryVehicle)
            {
                return toll; 
            }
            return toll;
        }
       

    }
}

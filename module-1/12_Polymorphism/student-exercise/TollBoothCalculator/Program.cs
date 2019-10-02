using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber ()
            {
                Random random = new Random();
                return random.Next(10, 240);
            }

            List<IVehicle> vehicles = new List<IVehicle>() {
                new Car(true), new Car(false), new Truck(4), new Truck(6), new Truck(8), new Tank(true)};

            int totalDistance = 0;
            double totalToll = 0;

            foreach (IVehicle vehicle in vehicles)
            {
                int holdsRandomNumber = RandomNumber();

                Console.WriteLine(vehicle + " traveled " + holdsRandomNumber + " owes " + vehicle.CalculateToll(holdsRandomNumber) + " as its toll.");

                totalDistance += holdsRandomNumber;
                totalToll += vehicle.CalculateToll(holdsRandomNumber);
            }
            Console.WriteLine("Total distance travelled was " + totalDistance + " miles. The total toll collected from all vehicles is " + totalToll);

            Console.ReadLine();

        }
    }
}

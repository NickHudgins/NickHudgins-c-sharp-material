using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a measurement in Feet!");
            int feet = int.Parse(Console.ReadLine());

            double inMeters = (feet * 0.3048);
            Console.WriteLine("In Meters that converts to {0}: ", inMeters);
            Console.ReadLine();

            Console.WriteLine("Enter a measurement in Meters!");
            int meters = int.Parse(Console.ReadLine());

            double inFeet = (meters * 3.2808399);
            Console.WriteLine("In Feet that converts to {0}: ", inFeet);
            Console.ReadLine();

        }
    }
}

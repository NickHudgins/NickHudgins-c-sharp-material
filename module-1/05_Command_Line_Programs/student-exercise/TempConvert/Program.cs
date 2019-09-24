using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahernheit Value to convert to Celsius!");
            int fahenheit = int.Parse(Console.ReadLine());

            int fahToCel = ((fahenheit - 32) / 9 * 5);
            Console.WriteLine("In Celsius that converts to {0}: ", fahToCel);
            Console.ReadLine();

            Console.WriteLine("Enter Celsius Value to conver to Fahernheit!");
            int celsius = int.Parse(Console.ReadLine());

            int celToFah = ((celsius * 9) / 5 + 32);
            Console.WriteLine("In Fahernheit that converts to {0}: ", celToFah);
            Console.ReadLine();

        }
    }
}

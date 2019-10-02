using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class Program
    {
        static void Main(string[] args)
        { double weight = 0;

            Console.WriteLine("Please enter the weight of the package: ");
            double enteredWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is this in Pounds or Ounces? Please enter O for Ounces or P for Pounds");
            string poundsOrOunces = Console.ReadLine();
            if (poundsOrOunces == "P")
            {
                weight = enteredWeight * 16;
            }
            if (poundsOrOunces == "O")
            {
                weight = enteredWeight;
            }

            Console.WriteLine("How many miles will it be traveling?");
            int distance = Convert.ToInt32(Console.ReadLine());

            List<IDeliveryDriver> deliveryMethods = new List<IDeliveryDriver>() {
            new USPSFirstClass(), new USPSSecondClass(), new USPSThirdClass(), new FedEx(), new SPU4DayGround(), new SPU2DayBusiness(), new SPUNextDay()};

            foreach(IDeliveryDriver deliveryMethod in deliveryMethods)
            {
                Console.WriteLine(deliveryMethods + " will cost $" + deliveryMethod.CalculateRate(distance, weight) + " to ship.");

            }

            Console.ReadLine(); //How do I get it to not display the System.Collections.Generic.List`1[PostageCalculator.Classes.IDeliveryDriver] before my answer??

        }
        
    }
}

using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your decimal");
            int decimalEntered = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalEntered > 0)
            {
                remainder = decimalEntered % 2;
                decimalEntered /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary : {0}", result);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }

        public Calculator()
        {

        }
        public int Add(int addend)
        {
            return Result = addend + Result;
        }
        public int Multiply(int multiplier)
        {
            return Result = Result * multiplier;
        }
        public int Power(int exponent)
        {
            double result = Result;
            double exp = exponent;
            result = Math.Pow(result, exp);
            Result = (int)result;
            return Result;

        }
        public void Reset()
        {
            Result = 0;
        }
        public int Subtract(int subtrahend)
        {
            return Result = Result - subtrahend;
        }



    }
}

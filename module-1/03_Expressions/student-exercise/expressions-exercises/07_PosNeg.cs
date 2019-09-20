using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
       Given 2 int values, return true if one is negative and one is positive. Except if the parameter
       "negative" is true, then return true only if both are negative.
       PosNeg(1, -1, false) → true
       PosNeg(-1, 1, false) → true
       PosNeg(-4, -5, true) → true
       */
        public bool PosNeg(int a, int b, bool negative)
        {
            bool aIsPos = a > 0;
            bool bIsPos = b > 0;

            if (negative == true)
            {
                return !aIsPos && !bIsPos;
            }

            if (aIsPos && !bIsPos || !aIsPos && bIsPos)
            {
                return true;
            }
            return false;
        }

    }
}

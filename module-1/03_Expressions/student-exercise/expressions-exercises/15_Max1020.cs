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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            bool a10To20 = a >= 10 && a <= 20;
            bool b10To20 = b >= 10 && b <= 20;

            if (a10To20 && !b10To20)
            {
                return a;
            }

            if (!a10To20 && b10To20)
            {
                return b;
            }
            if (b > a && b10To20)
            {
                return b;
            }
            if (!a10To20 && !b10To20)
            {
                return 0;
            }
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
            
        } 

    }
}

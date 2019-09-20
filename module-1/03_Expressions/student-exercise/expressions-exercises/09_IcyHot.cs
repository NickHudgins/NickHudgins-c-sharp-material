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
         Given two temperatures, return true if one is less than 0 and the other is greater than 100.
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        public bool IcyHot(int temp1, int temp2)
        {
            bool t1LessThan0 = temp1 < 0;
            bool t2GreaterThan100 = temp2 > 100;
            bool t1GreaterThan100 = temp1 > 100;
            bool t2LessThan0 = temp2 < 0;


            if (t1LessThan0 && t2GreaterThan100 || t1GreaterThan100 && t2LessThan0)
            {
                return true;
            } 

           
       
            return false;
             
        }

    }
}

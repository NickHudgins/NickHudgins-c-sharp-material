using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
         The string length will be at least 2.
         Right2("Hello") → "loHel"
         Right2("java") → "vaja"
         Right2("Hi") → "Hi"
         */
        public string Right2(string str)
        {
            int strLen = str.Length;

            return str.Substring(strLen - 2) + str.Substring (0, strLen - 2);
        }
    }
}

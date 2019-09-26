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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int i = str.IndexOf('x');

            if (i == -1 || i == str.Length - 1)
            {
                return false;
            }

            return str.Substring(i, i + 2).Equals("xx");
        }
    }
}

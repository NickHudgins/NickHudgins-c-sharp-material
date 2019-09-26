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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but
         the "a" can be any char. The "yak" strings will not overlap.
         StringYak("yakpak") → "pak"
         StringYak("pakyak") → "pak"
         StringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string yakResult = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i + 2 < str.Length && str[i] == 'y' && str[i +2] == 'k')
                {
                    i += 2;
                }
                else
                {
                    yakResult += str[i];
                }
            }
            return yakResult; //had to google the last 5 or 6 of these pretty heavily, will continue to try and understand better
        }
    }
}

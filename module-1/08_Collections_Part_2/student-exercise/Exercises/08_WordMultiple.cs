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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> stringBool = new Dictionary<string, bool>();

            Dictionary<string, int> stringCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (stringCount.ContainsKey(words[i]))
                {
                    stringCount[words[i]] = stringCount[words[i]] + 1;
                }
                else
                {
                    stringCount.Add(words[i], 1);
                }
            }
            foreach (KeyValuePair<string, int> item in stringCount)
            {
                if (item.Value >= 2)
                {
                    stringBool.Add(item.Key, true);
                }
                else
                {
                    stringBool.Add(item.Key, false);
                }
            }
            return stringBool;


        }

        
    }
}

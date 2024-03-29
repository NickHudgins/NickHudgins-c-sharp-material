﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         AltPairs("kitten") → "kien"
         AltPairs("Chocolate") → "Chole"
         AltPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            string  answer = "";
            for (int i = 0; i <str.Length; i += 4)
            {
                answer += str[i];
                if (i + 1 < str.Length)
                {
                    answer += str[i + 1];
                }
            }
            return answer; 
        }
    }
}

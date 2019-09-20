﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values,
        return true if 1 or more of them are teen.
        HasTeen(13, 20, 10) → true
        HasTeen(20, 19, 10) → true
        HasTeen(20, 10, 13) → true
        */
        public bool HasTeen(int a, int b, int c)
        {
            bool aIsTeen = a >= 13 && a <= 19;
            bool bIsTeen = b >= 13 && b <= 19;
            bool cIsTeen = c >= 13 && c <= 19;

            if (aIsTeen || bIsTeen || cIsTeen)
            {
                return true;
            }

            return false;
        }

    }
}

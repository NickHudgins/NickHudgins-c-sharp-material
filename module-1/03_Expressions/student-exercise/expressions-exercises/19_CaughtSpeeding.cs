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
         You are driving a little too fast, and a police officer stops you. Write code to compute the result,
         encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. If speed is 60 or less, the
         result is 0. If speed is between 61 and 80 inclusive, the result is 1. If speed is 81 or more, the
         result is 2. Unless it is your birthday -- on that day, your speed can be 5 higher in all cases.
         CaughtSpeeding(60, false) → 0
         CaughtSpeeding(65, false) → 1
         CaughtSpeeding(65, true) → 0
         */
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int noTicket = 0;
            int smallTicket = 1;
            int bigTicket = 2;
            int bottom = 60;
            int mid = 61;
            int midMax = 80;
            int top = 81;

            if (isBirthday)
            {
                bottom += 5;
                mid += 5;
                midMax += 5;
                top += 5;
            }

            bool sixtyOrLess = speed <= bottom;
            bool sixtyOneToEighty = speed >= mid && speed <= midMax;
            bool overEightyOne = speed >= top;

            if (sixtyOrLess)
            {
                return noTicket;
            }
            else if (sixtyOneToEighty)
            {
                return smallTicket;
            }
            else if (overEightyOne)
            {
                return bigTicket;
            }
            else
            {
                return 0;
            }
            
            
        }

    }
}

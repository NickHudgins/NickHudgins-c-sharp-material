using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        //FizzBuzz(3) "Fizz"
        //FizzBuzz(13) "Fizz"
        //FizzBuzz(35) "FizzBuzz"
        //FizzBuzz(5) "Buzz"
        //FizzBuzz(51) "Buzz"
        //FizzBuzz(53) "FizzBuzz"
        public string FizzBuzz(int i)
        {
            string myString = "";

            if (i >= 1 && i <= 100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    myString = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    myString = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    myString = "Buzz";
                }
                else
                {
                    myString = i.ToString();
                }
            }
            return myString; // my tests will not come up to test this against. 
                            // checked answers against group. Not super clear on the method used to test.
        }                  // will continue to look into testing this weekend.

    }
}

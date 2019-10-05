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



            }
            return 0;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FizzWriter
{
    class WriteFizzBuzz
    {
        static void FizzBuzz()
        {
            //Create a program to write out the result of FizzBuzz (1 to 300) to a -
            //- file called FizzBuzz.txt. The file should be written out to the same directory as this README file.


            //To run the application, the following command should be run at the root of this directory:
            //dotnet run --project FizzWriter / FizzWriter.csproj

            int num = 1;
            string uglyPath = "C:\\Users\\nickh\\nickhudgins-c-sharp-material\\module-1\\17_FileIO_Writing_out\\student-exercise\\FizzBuzz.txt";
            
            using (StreamWriter sw = new StreamWriter(uglyPath))
            //3 If the number is divisible by 3 or contains a 3, print “Fizz”
            //2 If the number is divisible by 5 or contains a 5, print “Buzz”
            //1 If the number is divisible by 3 and 5, print “FizzBuzz”
            //Otherwise print the number.
            while (num < 301)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    sw.WriteLine("FizzBuzz");
                }
                else if (num % 5 == 0 || num.ToString().Contains("5"))
                {
                    sw.WriteLine("Buzz");
                }
                else if (num % 3 == 0 || num.ToString().Contains("3"))
                {
                    sw.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.WriteLine("Donezo!");
            Console.ReadLine();
        }
    }
}

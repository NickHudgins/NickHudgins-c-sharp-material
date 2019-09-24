using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 1, resultNum;
            

            Console.WriteLine("Please enter a number for the Fibonaccizer!");
            int fibNum = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNum + " " + secondNum);

           for (int i = 2; i <fibNum; i++)
            {
                resultNum = firstNum + secondNum;
                Console.WriteLine(" " + resultNum);
                firstNum = secondNum;
                secondNum = resultNum;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

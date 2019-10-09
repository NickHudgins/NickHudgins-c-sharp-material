using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.WriteLine("Please enter the fully qualified file path name. ");
            string filePath = Console.ReadLine();
            Console.WriteLine();
            string searchString = "";
            int sum = 0;
            if (!File.Exists(filePath))
            {
                Console.WriteLine("This is not a valid qualified file name. Please enter a valid file name. ");
                filePath = Console.ReadLine();
            }
            if (File.Exists(filePath))
            {
                Console.WriteLine("Please enter a search string. ");
                searchString = Console.ReadLine();
            }
            Console.WriteLine("Should the search be case sensitive? (Y\\N) ");
            string isCaseSensitive = Console.ReadLine();
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        //line = sr.ReadLine();
                        //int myValue = ;
                        //sum += myValue;       //couldn't figure out how to add the line count. would like further instruction

                        //Console.WriteLine("The sum is " + sum);

                        if (isCaseSensitive == "Y")
                        {
                            if (line.Contains(searchString))
                            {
                                Console.WriteLine(line);
                            }
                        }
                        else
                        {
                            if (line.ToLower().Contains(searchString.ToLower()))
                            {
                                Console.WriteLine(line);
                            }

                           
                        }
                    }
                    
                }
            }
            Console.ReadLine();









        }




    }
}

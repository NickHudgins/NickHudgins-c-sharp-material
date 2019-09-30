using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Company()
        {

        }

        public string GetCompanySize()
        {
            if (NumberOfEmployees < 50)
            {
                return "small";
            }
            else if (NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
            {
                return "medium";
            }
            else
            {
                return "large";
            }
        }
        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }

    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public string GetFullName()
        {
            return FirstName + LastName;
        }
        public bool IsAdult()
        {
            if(Age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}

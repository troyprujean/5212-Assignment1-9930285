//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 4 - Person class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    public class Person
    {
        //auto implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        
        //constructor for the first and last name properties
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //method for concatenating a string containing the first and last name with a space between
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        //method for calculating the age based on the current year less the year of birth
        public int GetAge()
        {
            return  DateTime.Now.Year - YearOfBirth;
        }
    }
}

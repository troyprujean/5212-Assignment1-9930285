using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    class Person
    {
        string fName, lName;
        int birthYear;

        public string FirstName
        {
            get 
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return  DateTime.Now.Year - YearOfBirth;
        }
    }
}

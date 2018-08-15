using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question4;

namespace question5
{
    public class Student : Person //inheriting properties from parent class Person
    {
        //auto implemented properties
        public string Campus { get; set; }
        public int StudentID { get; set; }

        //constructor for the first name, last name and campus properties
        public Student(string firstName, string lastName, string campus) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Campus = campus;
        }

        //method for creating a random 4 digit number - starting from 1000 so that numbers with leading zeros arent cut short using the int type
        public int EnrollStudent()
        {
            Random ID = new Random();
            return ID.Next(1000,9999);
        }
    }
}

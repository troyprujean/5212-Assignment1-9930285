//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question4;

namespace question5
{
    public class Program
    {
        static bool validated = false; //boolean variable for input validation loops
        static string userFName; //string variable to hold the user input for instantiation with constructor
        static string userLName; //string variable to hold the user input for instantiation with constructor
        static string userCampus; //string variable to hold the user input for instantion with constructor
        public static void Main()
        {
            Console.WriteLine("Enter name of new person below");
            while (!validated) //while the boolean variable "validated" = false it will keep prompting the user for correct input
            {
                Console.Write("First name: ");
                userFName = Console.ReadLine();
                validated = IsValidString(userFName);
                //passing userFName to the validation method which will return a boolean value and set the "validated" variable accordingly
            }
            //upon validation of the user input the program will break out of the loop and continue
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while (!validated)
            {
                Console.Write("Last name: ");
                userLName = Console.ReadLine();
                validated = IsValidString(userLName);
            }
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while (!validated)
            {
                Console.Write("Campus: ");
                userCampus = Console.ReadLine();
                validated = IsValidString(userCampus);
            }
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            Console.WriteLine("\n\nCreating new person record ...\n");

            Console.WriteLine($"\nAdding new student record to {userCampus} campus ...\n");
            Student student1 = new Student(userFName, userLName, userCampus); //instantia
            student1.StudentID = student1.EnrollStudent(); //setting the autoimplemented student ID property with a random 4 digit number provided from the enroll student method
            Console.WriteLine($"{student1.FirstName} {student1.LastName} of {student1.Campus} campus has a student ID of {student1.StudentID}");
        }

        //boolean method for validating string inputs
        public static bool IsValidString(string input)
        {
            if (string.IsNullOrEmpty(input)) //checking to see if the user has entered nothing
            {
                Console.WriteLine("You did not enter anything, please try again"); //outputting error message
                return false;
            }
            //the below code converts each character in the indices of the string array to an integer to check if it is a number between 0 & 9 using their decimal ASCII codes
            //to determine whether the user has entered a number in the string. The tryparse method only works for the first character of the string array, for example if the
            //first character is a letter and the second a number it would still parse, so this method was implemented to prevent any number being entered in the string.
            foreach (char x in input)
            {   //checking for numeric values in each character indices of the string array
                int value = Convert.ToInt32(x);
                if (value >= 48 && value <= 57) //decimal ASCII values of 0 - 9
                {
                    Console.WriteLine("Invalid input, numeric values cannot be used"); //outputting error message
                    return false;
                }
            }
            return true;
            //if the input does not meet any of the above conditions it is deemed valid and the method will return true
        }

        //boolean method for validating integer inputs
        public static bool IsValidInt(string input)
        {
            int value; //int variable so the TryParse method has something to parse to
            if (string.IsNullOrEmpty(input)) //checking to see if the user has entered nothing
            {
                Console.WriteLine("You did not enter anything, please try again"); //outputting error message
                return false;
            }
            else if (int.TryParse(input, out value)) //checking to see if the user has entered a number
            {
                return true;
                //if the TryParse returns true, the input is deemed valid and the method will return true
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a whole number"); //outputting error message
                return false;
            }
        }
    }
}

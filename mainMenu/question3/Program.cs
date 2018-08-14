//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    public class Program
    {
        static bool validated = false; //boolean variable for input validation loops
        static string userInput; //variable to temporarily store user input for validation
        public static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine("Enter new car details below:");
            while (!validated) //while the boolean variable "validated" = false it will keep prompting the user for correct input
            {
                Console.Write("Colour: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput);
                //passing userInput to the validation method which will return a boolean value and set the "validated" variable accordingly
            }
            //upon validation of the user input the program will break out of the loop and continue
            car1.colour = userInput; //set the object property value of "colour" to that of "userInput" using the auto implemented setter
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while (!validated)
            {
                Console.Write("Make: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput);
            }
            car1.make = userInput; //set the object property value of "make" to that of "userInput" using the auto implemented setter
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while (!validated)
            {
                Console.Write("Gearbox: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput);
            }
            car1.gearbox = userInput; //set the object property value of "make" to that of "userInput" using the auto implemented setter
            validated = false;//reinstating the value of the boolean variable to false so it can be recycled

            //outputting the results of the objects properties to console using the auto implemented getters
            Console.WriteLine($"\n\nThe car is a {car1.colour} {car1.make} with a {car1.gearbox} transmission");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        //boolean method for validating user input
        public static bool IsValid(string input)
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
    }
}

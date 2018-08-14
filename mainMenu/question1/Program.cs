//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    public class Program
    {
        static bool validated = false; //boolean variable for input validation loops
        static string userInput; //variable to temporarily store user input for validation
        public static void Main()
        {
            Car car1 = new Car(); //instantiation of the new object
            Console.WriteLine("Enter new car details below:");
            while (!validated) //while the boolean variable "validated" = false it will keep prompting the user for correct input
            {
                Console.Write("Colour: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput); 
                //passing userInput to the validation method which will return a boolean value and set the "validated" variable accordingly
            }
            //upon validation of the user input the program will break out of the loop and continue
            car1.SetColour(userInput); //SetColour method to set the objects property value of "colour" to that of "userInput"
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while(!validated)
            {
                Console.Write("Make: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput);
            }
            car1.SetMake(userInput); //SetMake method to set the objects property value of "make" to that of "userInput"
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            while (!validated)
            {
                Console.Write("Gearbox: ");
                userInput = Console.ReadLine();
                validated = IsValid(userInput);
            }
            car1.SetGearbox(userInput); //SetGearbox method to set the objects property value of "gearbox" to that of "userInput"
            validated = false;//reinstating the value of the boolean variable to false so it can be recycled

            //outputting the results of the objects properties to console using the Get methods
            Console.WriteLine($"\n\nThe car is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        //boolean method for validating user input
        public static bool IsValid(string input)
        {
            int value; //int variable so the TryParse method has something to parse to
            if (string.IsNullOrEmpty(input)) //checking to see if the user has entered nothing
            {
                Console.WriteLine("You did not enter anything, please try again"); //outputting error message
                return false;
            }
            else if(int.TryParse(input, out value)) //checking to see if the user has entered a number
            {
                Console.WriteLine("Invalid input, numeric values cannot be used"); //outputting error message
                return false;
            }
            else return true;
            //if the input does not meet any of the above conditions it is deemed valid and the method will return true
        }
    }
}

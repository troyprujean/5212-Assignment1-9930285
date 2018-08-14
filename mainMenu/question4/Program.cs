//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Question 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    public class Program
    {
        static bool validated = false; //boolean variable for input validation loops
        static string userFName; //string variable to hold the user input for instantiation with constructor
        static string userLName; //string variable to hold the user input for instantiation with constructor
        static string birthYear; //string variable to hold the user input for the year of birth before validation
        public static void Main()
        {
            bool newPerson = true; //boolean variable for determining when to stop creating instances of the object
            Console.WriteLine("Enter name of new person below");
            var people = new List<Person>(); //instantiation of a new list using the Person class
            do
            {
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
                
                Console.WriteLine("\n\nCreating new person record ...\n");
                
                while (!validated)
                {
                    Console.Write("Enter year of birth: ");
                    birthYear = Console.ReadLine();
                    validated = IsValidInt(birthYear);
                    //passing birthYear to a method to confirm that the input is an integer
                }
                int userYOB = int.Parse(birthYear);
                //upon validation that birthYear is an int, the value of it is passed to an int variable called userYOB
                validated = false; //reinstating the value of the boolean variable to false so it can be recycled

                people.Add(new Person(userFName, userLName){YearOfBirth = userYOB});
                //dynamically instantiating the objects by adding them to a list, using the class constructor for first 
                //and last name and passing the value of userYOB to the auto implemented setter

                Console.WriteLine("\n\n");

                //for each loop to output the objects first and last name values and using the GetAge method to output the
                //age of the user after each time an object has been instantiated. The loop checks that the first and last 
                //name match that of which the userFName and userLName variables are holding to confirm that is is outputting
                //the correct entry of the list corresponding to the object that has been instantiated.
                foreach (Person x in people)
                {   
                    if (x.FirstName == userFName && x.LastName == userLName)
                    {
                        Console.WriteLine($"Person: {x.FirstName} {x.LastName} is {x.GetAge()} years old");
                    }
                }

                do //loop the following code until a valid key (either y or n) is pressed
                {
                    Console.Write("\nDo you want to enter a new person? <y/n>\n");
                    ConsoleKeyInfo userSelection = Console.ReadKey();
                    //checking to see if the user wants to add another object or not
                    if (userSelection.KeyChar == 'y')
                    {
                        newPerson = true; //if the user enters y the program will loop
                        Console.Clear();
                        validated = true;
                    }
                    else if (userSelection.KeyChar == 'n')
                    {
                        newPerson = false; //if the user enters n the program will break out of the main loop and end
                        validated = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input, please press either y or n");
                    }
                } while (!validated);
            validated = false; //reinstating the value of the boolean variable to false so it can be recycled

            } while (newPerson); //while the value of newPerson = true the program will keep allowing the user to create more objects
        
        Console.Clear();
        return;
        }

        //boolean method for validating string inputs
        public static bool IsValidString(string input)
        {
            int value; //int variable so the TryParse method has something to parse to
            if (string.IsNullOrEmpty(input)) //checking to see if the user has entered nothing
            {
                Console.WriteLine("You did not enter anything, please try again"); //outputting error message
                return false;
            }
            else if (int.TryParse(input, out value)) //checking to see if the user has entered a number
            {
                Console.WriteLine("Invalid input, numeric values cannot be used"); //outputting error message
                return false;
            }
            else return true;
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

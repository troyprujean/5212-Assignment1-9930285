using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool newPerson = true;
            Console.WriteLine("Enter name of new person below");
            var people = new List<Person>();
            do
            {
                Console.Write("First name: ");
                string userInput1 = Console.ReadLine();
                Console.Write("Last name: ");
                string userInput2 = Console.ReadLine();
                Console.WriteLine("\n\n");
                Console.WriteLine("Creating new person record ...");
                Console.WriteLine("\n");
                Console.Write("Enter year of birth: ");
                int userInput3 = int.Parse(Console.ReadLine());
                people.Add(new Person(userInput1, userInput2){YearOfBirth = userInput3});
                Console.WriteLine("\n\n");
                Console.Write("Do you want to enter a new person? <y/n>");
                string userInput4 = Console.ReadLine();
                if (userInput4 == "y")
                {
                    newPerson = true;
                }
                else if (userInput4 == "n")
                {
                    newPerson = false;
                }
            } while (newPerson);

            foreach(Person x in people)
            {
                Console.WriteLine($"Person: {x.FirstName} {x.LastName} is {x.GetAge()} years old");
            }
        }
    }
}

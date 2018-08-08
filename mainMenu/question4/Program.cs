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
            Console.WriteLine("Enter name of new person below");
            Console.Write("First name: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Last name: ");
            string userInput2 = Console.ReadLine();
            Person user1 = new Person(userInput1, userInput2);
            Console.WriteLine("\n\n");
            Console.WriteLine("Creating new person record ...");
            Console.WriteLine("\n");
            Console.Write("Enter year of birth: ");
            user1.YearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine($"Person: {user1.FirstName} {user1.LastName} is {user1.GetAge()} years old");
        }
    }
}

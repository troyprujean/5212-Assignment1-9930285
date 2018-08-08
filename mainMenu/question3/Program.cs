using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new car details below:");
            Console.Write("Colour: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Make: ");
            string userInput2 = Console.ReadLine();
            Console.Write("Gearbox: ");
            string userInput3 = Console.ReadLine();
            Car car1 = new Car(userInput1, userInput2, userInput3);
            Console.WriteLine("\n\n");
            Console.WriteLine($"The car is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission");
            Console.ReadLine();
        }
    }
}

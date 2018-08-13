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
            Car car1 = new Car();
            Console.WriteLine("Enter new car details below:");
            Console.Write("Colour: ");
            car1.colour = Console.ReadLine();
            Console.Write("Make: ");
            car1.make = Console.ReadLine();
            Console.Write("Gearbox: ");
            car1.gearbox = Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine($"The car is a {car1.colour} {car1.make} with a {car1.gearbox} transmission");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("Enter new car details below:");
            Console.Write("Colour: ");
            car1.SetColour(Console.ReadLine());
            Console.Write("Make: ");
            car1.SetMake(Console.ReadLine());
            Console.Write("Gearbox: ");
            car1.SetGearbox(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine($"The car is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission");
            Console.ReadLine();
        }
    }
}

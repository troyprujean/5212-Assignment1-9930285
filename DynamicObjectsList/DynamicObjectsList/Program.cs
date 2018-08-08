using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectsList
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("Please enter your first name:");
                string input1 = Console.ReadLine();
                Console.WriteLine("Please enter your last name:");
                string input2 = Console.ReadLine();
                people.Add(new Person(input1, input2));
            }

            foreach(Person x in people)
            {
                Console.WriteLine("Hello {0} {1}", x.Fname, x.Lname);
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        string fname, lname;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }

        }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }

        }

        public Person (string _fname, string _lname)
        {
            Fname = _fname;
            Lname = _lname;
        }
    }
}

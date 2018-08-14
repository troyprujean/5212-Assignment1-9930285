//Author: Troy Prujean
//Date: 14/08/2018
//Title: 5212 - Assignment 1 - Main Menu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question1;
using question3;
using question4;
using question5;

namespace mainMenu
{
    public class Program
    {   
        static bool exitProgram = false;
        public static void Main()
        {
            do
            {
                Console.WriteLine("Welcome to Troy's assignment submission for 5212 - Assignment 1");
                Console.WriteLine("Please press the number of the question you would like to view:\n");
                Console.WriteLine("(1) - Question 1");
                Console.WriteLine("(2) - Question 2");
                Console.WriteLine("(3) - Question 3");
                Console.WriteLine("(4) - Question 4");
                Console.WriteLine("(5) - Question 5");
                Console.WriteLine("(0) - Exit");
                ConsoleKeyInfo userSelection = Console.ReadKey();

                switch (userSelection.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        question1.Program.Main();
                        break;
                    case '2':
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        question3.Program.Main();
                        break;
                    case '4':
                        Console.Clear();
                        question4.Program.Main();
                        break;
                    case '5':
                        Console.Clear();
                        question5.Program.Main();
                        break;
                    case '0':
                        exitProgram = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input please press a number from 0 - 5\n");
                        break;
                }
            } while (!exitProgram);
        }
    }
}

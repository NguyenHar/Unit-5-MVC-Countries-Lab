using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_MVC_Countries_Lab
{
    internal class Validator
    {
        public static int GetNumber(int lower, int upper, string arg)
        {
            try
            {
                Console.Write($"{arg} ({lower}-{upper}): ");
                int input = int.Parse(Console.ReadLine());
                if (input >= lower && input <= upper)
                    return input;
                else
                {
                    Console.WriteLine("Input out of range.");
                    return GetNumber(lower, upper, arg);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input.");
                return GetNumber(lower, upper, arg);
            }
        }

        public static bool Continue(string message)
        {
            Console.Write($"{message} ");
            string prompt = Console.ReadLine();
            if (prompt == "y")
                return true;
            else if (prompt == "n")
                return false;
            else
            {
                Console.WriteLine("Invalid input.");
                return Continue(message);
            }
        }
    }
}

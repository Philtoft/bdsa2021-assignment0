using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool isLeapYear(int year)
        {
            // Check if it is a complete century
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}

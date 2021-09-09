using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a year");
                string yearInput = Console.ReadLine();

                int year = Int32.Parse(yearInput);

                if (isLeapYear(year))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            }
            catch (SystemException)
            {
                throw new Exception("A number was excepted, but another data type was received");
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong", e);
            }
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

using System;

namespace IntegersDiv5
{
    class Program
    {
        /*************************************
         * IntegersDiv5
         * Developer: Jeff Peterson
         * Date: 6/19/2017
         * Purpose: Find the number of digits divisible by 5 between two integers.
         * ***********************************/
        static void Main(string[] args)
        {
            // Variables
            int lower;
            int upper;
            int count = 0;
            bool result;

            Console.WriteLine("Finding digits divisible by 5 between two integers");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nProvide two integer digits to search between:");

            // Retrieve a number and validate it.
            while (true)
            {
                // Verify the value entered is acutally an integer with TryParse.
                Console.Write("Lower digit: ");
                result = int.TryParse(Console.ReadLine(), out lower);
                if (result == false)
                {
                    Console.WriteLine("\nYou entered an improper number.  The number must be an integer.");
                    continue;
                }

                Console.Write("Upper digit: ");
                result = int.TryParse(Console.ReadLine(), out upper);
                if (result == false)
                {
                    Console.WriteLine("\nYou entered an improper number.  The number must be an integer.");
                    continue;
                }

                if (lower == upper)
                {
                    Console.WriteLine("\nThe values you entered were the same.  Try again.");
                }
                else if (lower > upper)
                {
                    Console.WriteLine("\nThe lower value was higher than the upper value.  Try again.");
                }
                else
                {
                    break;
                }
            }

            // Find the number of digits divisible by 5 between the two given digits.
            // Loop to check each number one by one, then use modulus to count the desired number.
            // Display each number on the same line as we go.
            for (int i = lower + 1; i < upper; i++)
            {
                
                // We know the number is divisible by 5 if the remainder is 0.
                if (i % 5 == 0)
                {
                    // Write a comma and space after the first number is written.
                    if (count >= 1)
                    {
                        Console.Write(", ");
                    }
                    // Iterate the counter and display the number for the user.
                    count++;
                    Console.Write("{0}", i);
                }
            }

            Console.WriteLine("\nThe number of digits between {0} and {1} is {2}", lower, upper, count);
        }
    }
}

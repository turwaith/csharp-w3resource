/*
Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13
*/
using System;

namespace Exercice_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool isMultiple = false;

            Console.WriteLine("Test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13");
        
            Console.Write("Enter an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            isMultiple = (Math.Abs(userInput) % 13 == 0) || (Math.Abs(userInput) % 13 == 1) ? true : false;

            Console.WriteLine($"Output: {isMultiple}");
        }
    }
}

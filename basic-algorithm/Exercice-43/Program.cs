/*
Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both
*/
using System;

namespace Exercice_43
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool isMultiple =  false;

            Console.WriteLine("Check if a given non-negative given number is a multiple of 3 or 7, but not both");
        
            Console.Write("Enter your number (non-negative): ");
            userInput = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            if((userInput % 7 == 0) && (userInput % 3 == 0)) isMultiple = false;
            else if((userInput % 7 == 0) || (userInput % 3 == 0)) isMultiple = true;

            Console.WriteLine($"Output {isMultiple}");
        }
    }
}

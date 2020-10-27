/*
 Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
 */
using System;

/*
 check if a number is between a range:
    range           : 15 -> 20
    number to test  : [14,16,21];

    middle of range : (20 - 15)/2 = 2.5
    middle          : 20 - 2.5 = 17.5

    Math.abs(14 - 17.5) = 3.5
    3.5 <= 2.5 -> false

    Math.abs(16 - 17.5) = 1.5
    1.5 <= 2.5 -> true

    Math.abs(21 - 17.5) = 3.5
    3.5 <= 2.5 -> false
*/
namespace Exercice_04
{
    class Program
    {   
        private static bool CheckIfWithin(int number)
        {
            // number is between 90 && 110 OR between 190 && 210
            return (90 <= number && number <= 110) || (190 <= number && number <= 210) ? true : false;
        }
        static void Main(string[] args)
        {
            int userInput = 0;

            Console.WriteLine("Check a given integer and return true if it is within 10 of 100 or 200");

            Console.Write("Enter an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.Write($"The number {(CheckIfWithin(userInput) ? "is" : "is not")} within");
        }
    }
}

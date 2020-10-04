/*
Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
Sample Output:
    Input first integer:
    15
    True
*/
using System;

namespace Exercice_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Check if a given positive number is a multiple of 3 or a multiple of 7");
            Console.Write("Input first integer: ");
            userInput = Console.ReadLine();

            Console.WriteLine(checkMultipleOf(Convert.ToInt32(userInput)));
        }

        static Boolean checkMultipleOf(int numberToCheck, int a = 3, int b = 7)
        {
            return (numberToCheck%a == 0) || (numberToCheck%b == 0) ? true : false;
        }
    }
}

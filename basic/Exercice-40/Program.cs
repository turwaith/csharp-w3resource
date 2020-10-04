/*
Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
Test Data:
    Input first integer:
    15
    Input second integer:
    12
    Sample Output
    15
*/
using System;

namespace Exercice_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputOne = 0,
                userInputTwo = 0,
                numberToCheck = 20;

            Console.WriteLine("Check the nearest value of 20 of two given integers and return 0 if two numbers are same.");

            Console.Write("Input first integer: ");
            userInputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            userInputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((Math.Abs(numberToCheck-userInputOne)) < (Math.Abs(numberToCheck-userInputTwo)) ? userInputOne : userInputTwo);
        }
    }
}

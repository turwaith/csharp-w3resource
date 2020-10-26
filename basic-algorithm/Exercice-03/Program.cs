/*
Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30
*/
using System;

namespace Exercice_03
{
    class Program
    {
        static bool CheckTwoNumbers(int nbOne, int nbTwo)
        {
            return nbOne == 30 || nbTwo == 30 || (nbOne + nbTwo) == 30 ? true : false;
        }
        static void Main(string[] args)
        {
            int userInputOne = 0,
                userInputTwo = 0;

            Console.WriteLine("Check two given integers, and return true if one of them is 30 or if their sum is 30");

            Console.Write("Enter first integer: ");
            userInputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            userInputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckTwoNumbers(userInputOne, userInputTwo));
        }
    }
}

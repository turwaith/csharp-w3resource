/*
Write a C# Sharp program to check if two given non-negative integers have the same last digit
*/
using System;

namespace Exercice_23
{
    class Program
    {
        private static bool CheckLastDigit(string numberOne, string numberTwo)
        {
            if((Convert.ToInt32(numberOne) < 0) || (Convert.ToInt32(numberTwo) < 0)) 
                return false;
            else if(numberOne[^1] == numberTwo[^1])
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   numberOne = String.Empty,
                   numberTwo = String.Empty;

            Console.WriteLine("Check if two given non-negative integers have the same last digit");

            Console.Write("Enter two positive integers (coma separeted): ");
            userInput = Console.ReadLine();
            numberOne = userInput.Split(",")[0];
            numberTwo = userInput.Split(",")[1];

            Console.WriteLine(CheckLastDigit(numberOne, numberTwo));
        }
    }
}

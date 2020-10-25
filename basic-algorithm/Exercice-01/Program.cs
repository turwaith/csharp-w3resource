/*
Write a C# Sharp program to compute the sum of the two given integer values. 
If the two values are the same, then return triple their sum.
*/
using System;

namespace Exercice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputOne = 0,
                userInputTwo = 0;
            
            Console.WriteLine("Compute the sum of the two given integer values. If the two values are the same, then return triple their sum.");

            Console.Write("Enter first number : ");
            userInputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            userInputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Output             : {(userInputOne == userInputTwo ? 3*(userInputOne+userInputTwo) : userInputOne + userInputTwo)}");
        }
    }
}

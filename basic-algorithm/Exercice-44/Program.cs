/*
Write a C# Sharp program to check if a given number is within 2 of a multiple of 10
*/
using System;

namespace Exercice_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0,
                multipleOfTen = 0;
            bool isWithin = false;

            Console.WriteLine("Check if a given number is within 2 of a multiple of 10");
        
            Console.Write("Enter your number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            multipleOfTen = userInput % 10;

            isWithin = multipleOfTen <= 2 || multipleOfTen >= 8 ? true : false; 

            Console.WriteLine($"Output: {isWithin}");
        }
    }
}

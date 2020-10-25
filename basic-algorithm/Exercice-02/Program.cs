/*
Write a C# Sharp program to get the absolute difference between n and 51.
If n is greater than 51 return triple the absolute difference.
*/
using System;

namespace Exercice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0,
                result = 0;

            Console.WriteLine("Get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.");

            Console.Write("Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            result = userInput > 51 ? 3*(userInput-51) : -(userInput-51);
            
            Console.WriteLine($"Output        : {result}");
            
        }
    }
}

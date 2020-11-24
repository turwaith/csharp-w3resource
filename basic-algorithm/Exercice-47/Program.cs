/*
Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers
*/
using System;

namespace Exercice_47
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput;
            bool output = false;

            Console.WriteLine("Check if it is possible to add two integers to get the third integer from three given integers");
        
            Console.Write("Enter 3 integers (coma separeted): ");
            userInput = Console.ReadLine().Split(",");
            output = Convert.ToInt32(userInput[0]) + Convert.ToInt32(userInput[1]) == Convert.ToInt32(userInput[2]);

            Console.WriteLine($"Output: {output}");
        }
    }
}

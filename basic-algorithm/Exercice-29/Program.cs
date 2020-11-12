/*
Write a C# Sharp program to create a new string made of every other character starting with the first from a given string
*/
using System;

namespace Exercice_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userOutput = String.Empty;

            Console.WriteLine("Create a new string made of every other character starting with the first from a given string");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            userOutput += userInput[0];

            for(int i = 2; i < userInput.Length; i+=2)
            {
                userOutput += userInput[i];
            }

            Console.WriteLine($"Output: {userOutput}");

        }
    }
}

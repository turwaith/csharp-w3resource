/*
Write a C# Sharp program to check if a given string starts with 'C#' or not.
*/
using System;

namespace Exercice_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Check if a given string starts with 'C#' or not");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            Console.WriteLine(userInput[0..2] == "C#" ? "true" : "false");
        }
    }
}

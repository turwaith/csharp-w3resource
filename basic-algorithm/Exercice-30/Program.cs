/*
Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd"
*/
using System;

namespace Exercice_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userOutput = String.Empty;

            Console.WriteLine("Create a string like \"aababcabcd\" from a given string \"abcd\"");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            if(userInput.Length == 1) userOutput = userInput;
            else userOutput = userInput[0] + "" + userInput[0] + userInput[1] + userInput[0..3] + (userInput.Length > 3 ? userInput : "");

            Console.WriteLine($"Output: {userOutput}");
        }
    }
}

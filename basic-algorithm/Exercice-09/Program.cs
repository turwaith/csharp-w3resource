/*
Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more
*/
using System;

namespace Exercice_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Create a new string with the last char added at the front and back of a given string of length 1 or more");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            Console.WriteLine("Output           : " + userInput[^1] + userInput + userInput[^1]);
        }
    }
}

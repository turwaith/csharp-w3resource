/*
Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string.
If it appears return a string without 'yt' otherwise return the original string
*/
using System;

namespace Exercice_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Check if a string 'yt' appears at index 1 in a given string." +
                              "\nIf it appears return a string without 'yt' otherwise return the original string");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();
            
            Console.WriteLine(userInput[1..3] == "yt" ? userInput[0] + userInput[2..] : userInput);
        }
    }
}

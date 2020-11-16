/*
Write a C# Sharp program to create a new string from a give string where a specified
    character have been removed except starting and ending position of the given string
 */
using System;

namespace Exercice_36
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = String.Empty;
            char userChar = '\0';

            Console.WriteLine("Create a new string from a give string where a specified" +
                              "character have\nbeen removed except starting and ending position of the given string");

            Console.Write("Enter your string: ");
            userString =  Console.ReadLine();
            Console.Write("Enter your char: ");
            userChar =  Console.ReadLine().ToLower()[0];

            Console.WriteLine(userString[0] + userString[1..^1].ToString().Replace(userChar,'\0') + userString[^1]);
            
        }
    }
}

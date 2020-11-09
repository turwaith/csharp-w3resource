/*
Write a C# Sharp program to convert the last 3 characters of a given string in upper case.
If the length of the string has less than 3 then uppercase all the characters
 */
using System;

namespace Exercice_24
{
    class Program
    {
        private static string StringWithUpperEnd(string userEntry)
        {
            if(userEntry.Length < 3) return userEntry.ToUpper();
            else return userEntry[0..^3] + new string(userEntry[^3..]).ToUpper();
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Convert the last 3 characters of a given string in upper case." +
                              "\nIf the length of the string has less than 3 then uppercase all the characters");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();
            Console.WriteLine(StringWithUpperEnd(userInput));
        }
    }
}

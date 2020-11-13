/*
Write a C# Sharp program to count a substring of length 2 appears in a given
    string and also as the last 2 characters of the string.
Do not count the end substring
 */
using System;

namespace Exercice_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   lastTwoChars = String.Empty;
            int count = 0;

            Console.WriteLine("Count a substring of length 2 appears in a given" +
                              "string and also as the last 2 characters of the string.\n" +
                              "Do not count the end substring");

            Console.Write("Enter your string: ");
            userInput =  Console.ReadLine();
            lastTwoChars = userInput[^2..];

            for(int i = 0; i < userInput.Length - 3; i++) if(userInput[i..(i+2)] == lastTwoChars) count++;

            Console.WriteLine($"Outuput: {count}");
        }
    }
}

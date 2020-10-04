/*
 Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
    Test Data: PHP Tutorial
    Sample Output:
    P Tutorial
*/
using System;

namespace Exercice_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "HP";
            string data = "PHP Tutorial";

            Console.WriteLine($"Check if \"{word}\" appears at second position in a string and returns the string without \"{word}\".");
            Console.WriteLine($"Test Data: {data}");

            if(data.Substring(1).StartsWith(word)) Console.WriteLine(data.Remove(1,2));                     
        }
    }
}

/*
Write a C# Sharp program to concat two given strings.
If the given strings have different length remove
    the characters from the longer string
*/
using System;

namespace Exercice_82
{
    class Program
    {
    public static string NewString(string originalOne, string originalTwo)
    {
        return originalOne.Length > originalTwo.Length ?
            originalOne[^(originalTwo.Length)..] + originalTwo :
            originalOne + originalTwo[^(originalOne.Length)..];
    }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Concat two given strings.
If the given strings have different length remove
    the characters from the longer string");

            Console.WriteLine(NewString("abc", "abcd"));
            Console.WriteLine(NewString("Python", "Python"));
            Console.WriteLine(NewString("JS", "Python"));
            Console.WriteLine(NewString("Python", "JS"));
        }
    }
}

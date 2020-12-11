/*
Write a C# Sharp program to create a new string taking the first character
    from a given string and the last character from another given string.
If the length of any given string is 0, use '#' as its missing character
*/
using System;

namespace Exercice_77
{
    class Program
    {
        public static string NewString(string originalOne, string originalTwo)
        {
            return (originalOne.Length > 0 ? originalOne.Substring(0,1) : "#") +
                   (originalTwo.Length > 0 ? originalTwo.Substring(originalTwo.Length - 1) : "#");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new string taking the first character
    from a given string and the last character from another given string.
If the length of any given string is 0, use '#' as its missing character");

            Console.WriteLine(NewString("Hello", "Hi"));
            Console.WriteLine(NewString("Python", "PHP"));
            Console.WriteLine(NewString("JS", "JS"));
            Console.WriteLine(NewString("Csharp", ""));
        }
    }
}

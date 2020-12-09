/*
Write a C# Sharp program to create a new string of length 2
    starting at the given index of a given string
*/
using System;

namespace Exercice_74
{
    class Program
    {
        public static string NewString(string original, int index)
        {
            return original[index..(index + 2)];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string of length 2 starting at the given index of a given string");

            Console.WriteLine(NewString("Hello", 1));
            Console.WriteLine(NewString("Python", 2));
        }
    }
}

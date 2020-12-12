/*
Write a C# Sharp program to create a new string from a given string after swapping last two characters
*/
using System;

namespace Exercice_79
{
    class Program
    {
        public static string NewString(string original)
        {
            if(original.Length <= 1) return original;
            return original.Substring(0,original.Length) + original[^1]+original[^2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new string from a given string after swapping last two characters");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("PHP"));
            Console.WriteLine(NewString("JS"));
            Console.WriteLine(NewString("C"));
        }
    }
}

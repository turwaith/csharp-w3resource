/*
Write a C# Sharp program to move the last two characters to
    the start of a given string of length at least two
*/
using System;

namespace Exercice_69
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length >= 2 ? original[^2..] +  original[..^2] : original;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Move the last two characters to the start\n" +
                              "of a given string of length at least two");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Js"));
            Console.WriteLine(NewString("A"));
        }
    }
}

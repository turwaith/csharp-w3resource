/*
Write a C# Sharp program to move the first two characters to the
    end of a given string of length at least two
*/
using System;

namespace Exercice_68
{
    class Program
    {
        public static string NewString(string original)
        {
            return original.Length >= 2 ? original[2..]+original[0..2] : original;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Move the first two characters to the end\n" +
                              "of a given string of length at least two");

            Console.WriteLine(NewString("Hello"));
            Console.WriteLine(NewString("Js"));
            Console.WriteLine(NewString("A"));            
        }
    }
}

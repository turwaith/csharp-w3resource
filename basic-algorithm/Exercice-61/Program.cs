/*
Write a C# Sharp program to insert a given string into middle of the another given string of length 4
*/
using System;

namespace Exercice_61
{
    class Program
    {
        public static string InsertString(string originalString, string stringToInsert)
        {
            return originalString[0..2] + stringToInsert + originalString[2..];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a given string into middle of the another given string of length 4");

            Console.WriteLine(InsertString("[[]]","Hello"));
            Console.WriteLine(InsertString("(())", "Hi"));
        }
    }
}

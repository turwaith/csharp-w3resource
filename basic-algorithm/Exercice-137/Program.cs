/*
Write a C# Sharp program to create a new array using the first n strings
    from a given array of strings. (n>=1 and <=length of the array)
*/
using System;

namespace Exercice_137
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array using the first n strings
    from a given array of strings. (n>=1 and <=length of the array)");

            Console.WriteLine(String.Join(",",GetNewArray(new string[]{"a","b","bb","c","ccc"}, 3)));
        }
        static string[] GetNewArray(string[] sentences, int size)
        {
            Console.Write($"[{String.Join(",",sentences)}] ->");
            return sentences[0..size];
        }
    }
}

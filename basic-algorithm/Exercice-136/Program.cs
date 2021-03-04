/*
Write a C# Sharp program to count the number of strings with given length in given array of strings
*/
using System;

namespace Exercice_136
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Count the number of strings with given length in given array of strings");

            Console.WriteLine(GetMatchLength(new string[]{"a", "b", "bb", "c", "ccc" }, 1));
            Console.WriteLine(GetMatchLength(new string[]{"a", "b", "bb", "c", "ccc" }, 2));
        }
        static int GetMatchLength(string[] arrStrings, int size)
        {
            int count = 0;

            foreach(string item in arrStrings)
                count += item.Length == size ? 1 : 0;
            
            Console.Write($"[{String.Join(",",arrStrings)}] (length of {size}) -> ");

            return count;
        }
    }
}
